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
        public static string LocalFilePath = @"../../../../quotable.core/quotes.txt";
        public static string RemoteFilePath = @"~/../../quotable.core/quotes.txt";
        public static Quotes invalid = new Quotes() { Author = "-", Quote = "Unavailable", ID = -1 };
    }
}
