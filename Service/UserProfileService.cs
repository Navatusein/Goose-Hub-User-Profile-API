using Minio.DataModel.Notification;
using MongoDB.Bson;
using MongoDB.Driver;
using UserProfileAPI.Dto;
using UserProfileAPI.Models;

namespace UserProfileAPI.Service
{
    /// <summary>
    /// 
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
        public async Task<UserProfile> GetAsync(string id)
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
        public async Task<WishList> GetWishListAsync(string wishListId, string userProfileId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<bool> AddContentNotificationAsync(string contentId, Notification notification)
        {
            var filter = Builders<UserProfile>.Filter.ElemMatch("WishList", Builders<WishList>.Filter.And(
                Builders<WishList>.Filter.Eq("Notify", true),
                Builders<WishList>.Filter.ElemMatch("Content", Builders<Content>.Filter.Eq("ContentId", contentId))
            ));

            var update = Builders<UserProfile>.Update.Push("NotificationList", notification);

            var updateOptions = new UpdateOptions { IsUpsert = false };

            var result = await _collection.UpdateManyAsync(filter, update, updateOptions);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<bool> AddNotificationAsync(string userProfileId, Notification notification)
        {
            var filter = Builders<UserProfile>.Filter.Eq("Id", userProfileId);

            var update = Builders<UserProfile>.Update.Push("NotificationList", notification);

            var updateOptions = new UpdateOptions { IsUpsert = false };

            var result = await _collection.UpdateManyAsync(filter, update, updateOptions);
            return true;
        }
    }
}
