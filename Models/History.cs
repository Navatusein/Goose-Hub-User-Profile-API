
using System.ComponentModel.DataAnnotations;
using UserProfileAPI.Dtos;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// Model for store browsing history
    /// </summary>
    public class History
    {
        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        public string ContentId { get; set; } = null!;

        /// <summary>
        /// Gets or Sets ViewDate
        /// </summary>
        public DateOnly ViewDate { get; set; }
    }
}
