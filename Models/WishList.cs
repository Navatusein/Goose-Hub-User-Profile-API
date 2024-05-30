using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using UserProfileAPI.Dtos;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// Model for store user wish list
    /// </summary>
    public class WishList
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Notify
        /// </summary>
        public bool Notify { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        public List<WishListContent> Contents { get; set; } = null!;
    }
}
