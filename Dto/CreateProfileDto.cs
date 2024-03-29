using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dto
{
    public class CreateProfileDto
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
        public string Email { get; set; } = null!;
    }
}
