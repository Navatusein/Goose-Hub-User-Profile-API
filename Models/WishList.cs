using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using UserProfileAPI.Dto;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class WishList
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        public ContentDto Content { get; set; } = null!;
    }
}
