using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dtos
{
    /// <summary>
    /// Model for short version of UserProfile
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
        public string? AvatarUrl { get; set; } = null!;

        /// <summary>
        /// Gets or Sets AvatarPath
        /// </summary>
        public string? AvatarPath { get; set; } = null!;
    }
}
