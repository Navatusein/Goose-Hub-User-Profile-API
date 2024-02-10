using System.Text;

namespace UserProfileAPI.Dto
{ 
    /// <summary>
    /// 
    /// </summary>
    public class WishListDto
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        public ContentDto Content { get; set; } = null!;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WishListDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
