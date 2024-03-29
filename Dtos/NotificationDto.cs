using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dtos
{
    /// <summary>
    /// Dto for Notification
    /// </summary>
    public class NotificationDto
    {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [Required]
        public string Message { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [Required]
        public string? LinkRaw { get; set; }
    }
}
