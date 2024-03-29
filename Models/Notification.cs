using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// Model for store user notifications
    /// </summary>
    public class Notification
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
