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
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [Required]
        public string AvatarUrl { get; set; } = null!;

        /// <summary>
        /// Gets or Sets AvatarPath
        /// </summary>
        [Required]
        public string AvatarPath { get; set; } = null!;
    }
}
