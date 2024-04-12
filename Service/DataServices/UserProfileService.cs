using Minio.DataModel.Notification;
using MongoDB.Bson;
using MongoDB.Driver;
using UserProfileAPI.Dtos;
using UserProfileAPI.Models;

namespace UserProfileAPI.Service.DataServices
{
    /// <summary>
    /// UserProfile MongoDB service
    /// </summary>
    public class UserProfileService
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<UserProfileService>();

        private readonly IMongoCollection<UserProfile> _collection;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserProfileService(IConfiguration config, MongoDbConnectionService connectionService)
        {
            var collectionName = config.GetSection("MongoDB:CollectionUserName").Get<string>();
            _collection = connectionService.Database.GetCollection<UserProfile>(collectionName);
        }

        /// <summary>
        /// Get UserProfile
        /// </summary>
        public async Task<UserProfile> GetByIdAsync(string id)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", id);
            var model = await _collection.Find(filter).FirstOrDefaultAsync();
            return model;
        }

        /// <summary>
        /// Create UserProfile
        /// </summary>
        public async Task<UserProfile> CreateAsync(UserProfile model)
        {
            await _collection.InsertOneAsync(model);
            return model;
        }

        /// <summary>
        /// Update UserProfile
        /// </summary>
        public async Task<UserProfile> UpdateAsync(string id, UserProfile model)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", id);
            var options = new FindOneAndReplaceOptions<UserProfile>()
            {
                ReturnDocument = ReturnDocument.After
            };

            model = await _collection.FindOneAndReplaceAsync(filter, model, options);
            return model;
        }

        /// <summary>
        /// Delete UserProfile
        /// </summary>
        public async Task<bool> DeleteAsync(string id)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", id);
            var model = await _collection.FindOneAndDeleteAsync(filter);
            return model != null;
        }

        /// <summary>
        /// Get UserProfile
        /// </summary>
        public async Task<UserProfile> GetUserProfileWishListAsync(string wishListId, string userProfileId)
        {
            var filter = Builders<UserProfile>.Filter.ElemMatch("WishLists", Builders<WishList>.Filter.Eq("Id", wishListId));
            var projection = Builders<UserProfile>.Projection.Include("WishLists.$");

            var model = await _collection.Find(filter).Project<UserProfile>(projection).SingleOrDefaultAsync();

            return model;
        }

        /// <summary>
        /// Add Content Notification
        /// </summary>
        public async Task<bool> AddContentNotificationAsync(string contentId, Notification notification)
        {
            var filter = Builders<UserProfile>.Filter.ElemMatch("WishLists", Builders<WishList>.Filter.And(
                Builders<WishList>.Filter.Eq("Notify", true),
                Builders<WishList>.Filter.ElemMatch("Contents", Builders<WishListContent>.Filter.Eq("ContentId", contentId))
            ));

            var update = Builders<UserProfile>.Update.Push("Notifications", notification);

            var updateOptions = new UpdateOptions { IsUpsert = false };

            var result = await _collection.UpdateManyAsync(filter, update, updateOptions);

            if (result.IsModifiedCountAvailable && result.ModifiedCount > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Add Notification
        /// </summary>
        public async Task<bool> AddNotificationAsync(string userProfileId, Notification notification)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", userProfileId);
            var update = Builders<UserProfile>.Update.Push("Notifications", notification);
            var updateOptions = new UpdateOptions { IsUpsert = false };

            var result = await _collection.UpdateManyAsync(filter, update, updateOptions);

            if (result.IsModifiedCountAvailable && result.ModifiedCount > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Add Avatar
        /// </summary>
        public async Task<bool> AddAvatarAsync(string id, string filePath)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", id);
            var update = Builders<UserProfile>.Update.Set("AvatarPath", filePath);

            var result = await _collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount > 0;
        }

        /// <summary>
        /// Remove Avatar
        /// </summary>
        public async Task<bool> RemoveAvatarAsync(string id)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", id);
            var update = Builders<UserProfile>.Update.Set<string?>("AvatarPath", null);

            var result = await _collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount > 0;
        }
    }
}
