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
        public IEnumerable<string> quotes;

        /// <summary>
        /// Quote generator constructor
        /// </summary>
        /// <param name="listOfQuotes">Takes in a list of quotes</param>
        public DefaultRandomQuoteGenerator(IEnumerable<string> listOfQuotes){
            quotes = listOfQuotes;
        }

        /// <summary>
        /// Generates quotes from a text file called quotes.txt found in the project directory
        /// </summary>
        /// <returns>list of quotes</returns>
        public static IEnumerable<string> generateQuotes(){
            List<string> list = new List<string>();
            String path = @"../../../.../quotable.core/quotes.txt";
            string[] lines = File.ReadAllLines(path);
  
            foreach (string line in lines)  {
                list.Add(line);
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
