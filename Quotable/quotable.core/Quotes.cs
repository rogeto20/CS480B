using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Class containing the quote structure;
    /// The ID, Quote and the Author
    /// </summary>
    public class Quotes
    {
        /// <summary>
        /// The ID of a quote
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The text contained in a quote
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
        /// The author of a quote
        /// </summary>
        public string Author { get; set; }
    }
}
