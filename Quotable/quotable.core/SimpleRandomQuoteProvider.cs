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
        DefaultRandomQuoteGenerator quoteGenerator;
        Quotes invalid = new Quotes();
        
        public SimpleRandomQuoteProvider(string path)
        {
            quoteGenerator = DefaultRandomQuoteGenerator.getGenerator(path);
            invalid.ID = -1;
        }

        /// <summary>
        /// Gets the number of quotes provided
        /// </summary>
        /// <param name="numOfQuotes">Number of quotes requested</param>
        /// <returns>list of quotes</returns>
        public IEnumerable<Quotes> getQuotes(long numOfQuotes)
        {
            List<Quotes> list = new List<Quotes>();
            List<Quotes> quotes = (List<Quotes>)quoteGenerator.quotes;
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
        
        /// <summary>
        /// This method returns a quote by ID
        /// </summary>
        /// <returns></returns>
        public Quotes getQuotesbyID(int id)
        {
            List<Quotes> quotes = (List<Quotes>)quoteGenerator.quotes;
            if (id < quotes.Count && id > 0)
            {
                return quotes[id];
            }
            else
            {
                return invalid;
            }
        }

    }
}
