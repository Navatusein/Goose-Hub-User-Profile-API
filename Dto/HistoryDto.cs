using System.Text;

namespace UserProfileAPI.Dto
{ 
    /// <summary>
    /// 
    /// </summary>
    public class HistoryDto
    {
        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        public string ContentId { get; set; } = null!;

        /// <summary>
        /// Gets or Sets ViewDate
        /// </summary>
        public DateTime ViewDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryDto {\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ViewDate: ").Append(ViewDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
