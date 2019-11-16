using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// This class contains constants that are being reused all over the project. 
    /// It was made to minimize the changes that would need to be made when trying to access
    /// Quotes
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// This is the string with the file path when the API is run locally
        /// </summary>
        public static string LocalFilePath = @"../../../../quotable.core/quotes.txt";

        /// <summary>
        /// This is the string with the file path when the API is run remotely
        /// </summary>
        public static string RemoteFilePath = @"~/../../quotable.core/quotes.txt";

        /// <summary>
        /// This is the invalid quote that is returned for requests that do not exist
        /// </summary>
        public static Quotes invalid = new Quotes() { Author = "-", Quote = "Unavailable", ID = -1 };
    }
}
