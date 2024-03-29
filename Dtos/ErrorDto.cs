using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dtos
{
    /// <summary>
    /// Model for error responses
    /// </summary>
    public class ErrorDto
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [Required]
        public string Message { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [Required]
        public string Code { get; set; } = null!;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        public ErrorDto(string message, string code)
        {
            Id = Guid.NewGuid().ToString();
            Message = message;
            Code = code;
        }

        /// <summary>
        /// 
        /// </summary>
        public ErrorDto()
        {
            Id = Guid.NewGuid().ToString();
            Message = string.Empty;
            Code = string.Empty;
        }

    }
}
