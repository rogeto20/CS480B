using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace quotable.core
{
    /// <summary>
    /// Class containing the quote generator
    /// </summary>
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
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
        private static IEnumerable<Quotes> generateQuotes(){
            List<Quotes> list = new List<Quotes>();
            String path = @"~'/../../quotable.core/quotes.txt";
            string[] lines = File.ReadAllLines(path);
  
            foreach (string line in lines)  {
                Quotes quote = new Quotes();
                quote.ID = Array.IndexOf(lines, line);
                quote.Quote = line;
                quote.Author = "Ray Hudson";
                list.Add(quote);
            }

            return list;
        }

        /// <summary>
        /// Unimplemented method implemented from interface
        /// </summary>
        public IEnumerable<string> getQuotes(long numOfQuotes){
            throw new NotImplementedException();
        }

        /// <summary>
        /// Getter for the quoteGenerator object
        /// </summary>
        public static DefaultRandomQuoteGenerator getGenerator(){
            DefaultRandomQuoteGenerator quoteGenerator = new DefaultRandomQuoteGenerator(generateQuotes());
            return quoteGenerator;
        }
    }
}
