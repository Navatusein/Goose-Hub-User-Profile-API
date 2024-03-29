using MassTransit;
using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.MassTransit.Events
{
    /// <summary>
    /// 
    /// </summary>
    [EntityName("user-profile-api-send-notification")]
    public class SendNotificationEvent
    {
        /// <summary>
        /// Gets or Sets Content ID
        /// </summary>
        [Required]
        public string UserProfileId { get; set; } = null!;

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
