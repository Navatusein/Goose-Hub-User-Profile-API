using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dto
{ 
    /// <summary>
    /// 
    /// </summary>
    public class ContentDto
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
