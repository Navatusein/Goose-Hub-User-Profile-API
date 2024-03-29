
using System.ComponentModel.DataAnnotations;
using UserProfileAPI.Dto;

namespace UserProfileAPI.Models
{
    /// <summary>
    /// 
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
        public DateTime ViewDate { get; set; }
    }
}
