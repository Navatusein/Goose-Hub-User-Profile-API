using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// Model for store content in wish list
    /// </summary>
    public class WishListContent
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
