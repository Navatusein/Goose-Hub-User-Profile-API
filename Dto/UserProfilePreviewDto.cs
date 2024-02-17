using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class UserProfilePreviewDto
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [Required]
        public string IconUrl { get; set; } = null!;
    }
}
