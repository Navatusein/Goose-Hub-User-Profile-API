using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dtos
{
    /// <summary>
    /// Dto for UserProfile
    /// </summary>
    public class UserProfileDto
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
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
        /// Gets or Sets Email
        /// </summary>
        public DateOnly? Birthday { get; set; }

        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets AvatarPath
        /// </summary>
        public string? AvatarPath { get; set; }

        /// <summary>
        /// Gets or Sets WishList
        /// </summary>
        public List<WishListDto> WishLists { get; set; } = null!;

        /// <summary>
        /// Gets or Sets HistoryList
        /// </summary>
        public List<HistoryDto> History { get; set; } = null!;


        /// <summary>
        /// Gets or Sets NotificationList
        /// </summary>
        public List<NotificationDto> Notifications { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [Required]
        public bool IsPrivate { get; set; }
    }
}
