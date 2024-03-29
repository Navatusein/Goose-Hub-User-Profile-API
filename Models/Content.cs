using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        [Required]
        public string ContentId { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        public int Priority { get; set; }
    }
}
