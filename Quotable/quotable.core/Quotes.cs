using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace quotable.core
{
    /// <summary>
    /// Class containing the quote structure;
    /// The Id, Quote and the Author
    /// </summary>
    public class Quotes
    {
        /// <summary>
        /// The Id of a quote
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The text contained in a quote
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
		/// The collection of authors of the Quote
		/// </summary>
		[NotMapped]
        public IEnumerable<Author> Author => from x in QuoteAuthor select x.Author;

        /// <summary>
		/// The relation of document to author
		/// </summary>
		public ICollection<QuoteAuthor> QuoteAuthor { get; set; } = new List<QuoteAuthor>();
    }
}
