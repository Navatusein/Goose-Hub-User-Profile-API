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
    }
}
