using System;
using System.Collections.Generic;
using System.IO;

namespace quotable.core
{
    /// <summary>
    /// Class containing the quote generator
    /// </summary>
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        /// <summary>
        /// This is the list of quotes that is returned after they are generated from the .txt file
        /// </summary>
        public IEnumerable<Quotes> quotes;
        
        /// <summary>
        /// Quote generator constructor
        /// </summary>
        /// <param name="listOfQuotes">Takes in a list of quotes</param>
        public DefaultRandomQuoteGenerator(IEnumerable<Quotes> listOfQuotes){
            quotes = listOfQuotes;
        }

        /// <summary>
        /// Generates quotes from a text file called quotes.txt found in the project directory
        /// </summary>
        /// <returns>list of quotes</returns>
        private static IEnumerable<Quotes> generateQuotes(string directory){
            List<Quotes> list = new List<Quotes>();
            string[] lines = File.ReadAllLines(directory);
  
            foreach (string line in lines)  {
                Quotes quote = new Quotes();
                quote.ID = Array.IndexOf(lines, line);
                quote.Quote = line;
                //quote.Author = "Ray Hudson";
                list.Add(quote);
            }

            return list;
        }

        /// <summary>
        /// Unimplemented method implemented from interface
        /// </summary>
        public IEnumerable<Quotes> getQuotes(long numOfQuotes){
            throw new NotImplementedException();
        }

        /// <summary>
        /// Getter for the quoteGenerator object
        /// </summary>
        /// <returns>a quote generator</returns>
        public static DefaultRandomQuoteGenerator getGenerator(string path){
            DefaultRandomQuoteGenerator quoteGenerator = new DefaultRandomQuoteGenerator(generateQuotes(path));
            return quoteGenerator;
        }
    }
}
