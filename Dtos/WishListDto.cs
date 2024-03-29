namespace UserProfileAPI.Dtos
{
    /// <summary>
    /// Dto for WishList
    /// </summary>
    public class WishListDto
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Notify
        /// </summary>
        public bool Notify { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        public List<WishListContentDto> ContentList { get; set; } = null!;

        

    }
}
