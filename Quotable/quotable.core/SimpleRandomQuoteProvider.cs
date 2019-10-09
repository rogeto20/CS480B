using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
   /// <summary>
   /// Class providing random quotes
   /// </summary>
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        DefaultRandomQuoteGenerator quoteGenerator = DefaultRandomQuoteGenerator.getGenerator();

        /// <summary>
        /// Gets the number of quotes provided
        /// </summary>
        /// <param name="numOfQuotes">Number of quotes requested</param>
        /// <returns>list of quotes</returns>
        public IEnumerable<string> getQuotes(long numOfQuotes)
        {
            List<string> list = new List<string>();
            List<string> quotes = (List<string>)quoteGenerator.quotes;
            if (numOfQuotes > quotes.Count)
            {
                return quotes;
            }
            else
            {
                for(int i = 0; i<numOfQuotes; i++)
                {
                    list.Add(quotes[i]);
                }
                return list;
            }
            
        }

        /// <summary>
        /// This method returns all the strings that are generated
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Quotes> getQuotes()
        {
            return (List<Quotes>)quoteGenerator.quotes;
        }
    }
}
