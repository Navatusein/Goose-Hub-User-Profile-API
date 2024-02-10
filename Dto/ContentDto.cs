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

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentDto {\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
