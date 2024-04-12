using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dtos
{
    /// <summary>
    /// Model for avatar upload
    /// </summary>
    public class UploadDto
    {
        /// <summary>
        /// Gets or Sets IsEpisode
        /// </summary>
        [Required]
        public IFormFile File { get; set; } = null!;
    }
}
