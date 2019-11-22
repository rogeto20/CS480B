namespace quotable.core
{
    /// <summary>
	/// Represents the many-to-many relation between quotes and authors
	/// </summary>
    public class QuoteAuthor
    {
        /// <summary>
		/// The Id of the quote related to the author.
		/// </summary>
		public long QuoteId { get; set; }
        /// <summary>
        /// The quote related to the author.
        /// </summary>
        public Quotes Quote { get; set; }

        /// <summary>
        /// The Id of the author related to the quote.
        /// </summary>
        public long AuthorId { get; set; }
        /// <summary>
        /// The author related to the quote.
        /// </summary>
        public Author Author { get; set; }
    }
}
