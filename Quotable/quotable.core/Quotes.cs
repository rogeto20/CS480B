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
        public int ID { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }
    }
}
