using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserProfileAPI.Dto
{ 
    /// <summary>
    /// 
    /// </summary>
    public class UserProfileDto
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
        /// Gets or Sets Email
        /// </summary>
        [Required]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [Required]
        public string IconUrl { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [Required]
        public string IconId { get; set; } = null!;

        /// <summary>
        /// Gets or Sets WishLists
        /// </summary>
        public List<WishListDto> WishLists { get; set; } = null!;

        /// <summary>
        /// Gets or Sets HistoryList
        /// </summary>
        public List<HistoryDto> HistoryList { get; set; } = null!;


        /// <summary>
        /// Gets or Sets NotificationList
        /// </summary>
        public List<NotificationDto> NotificationList { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [Required]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  WishLists: ").Append(WishLists).Append("\n");
            sb.Append("  HistoryList: ").Append(HistoryList).Append("\n");
            sb.Append("  NotificationList: ").Append(NotificationList).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
