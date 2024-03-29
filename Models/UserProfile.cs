using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using UserProfileAPI.Dtos;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// Model for store user profile data
    /// </summary>
    public class UserProfile
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
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Gets or Sets AvatarPath
        /// </summary>
        [Required]
        public string AvatarPath { get; set; } = null!;

        /// <summary>
        /// Gets or Sets WishList
        /// </summary>
        public List<WishList> WishLists { get; set; } = null!;

        /// <summary>
        /// Gets or Sets HistoryList
        /// </summary>
        public List<History> History { get; set; } = null!;


        /// <summary>
        /// Gets or Sets NotificationList
        /// </summary>
        public List<Notification> Notifications { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [Required]
        public bool IsPrivate { get; set; }
    }
}
