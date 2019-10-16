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
        
        /// <summary>
        /// Constructor for an object that provides quotes.
        /// </summary>
        /// <param name="path"> a folder directory from which the quote generator gets quotes from</param>
        public SimpleRandomQuoteProvider(string path)
        {
            quoteGenerator = DefaultRandomQuoteGenerator.getGenerator(path);
        }

        /// <summary>
        /// Gets the number of quotes from the number provided
        /// </summary>
        /// <param name="numOfQuotes">Number of quotes to be returned</param>
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
        /// This method returns all the quotes that are generated
        /// </summary>
        /// <returns>list of quotes</returns>
        public IEnumerable<Quotes> getQuotes()
        {
            return (List<Quotes>)quoteGenerator.quotes;
        }
        
        /// <summary>
        /// Gets quotes by the id provided
        /// </summary>
        /// <param name="id">the id provided</param>
        /// <returns>quote requested</returns>
        public Quotes getQuotesbyID(int id)
        {
            List<Quotes> quotes = (List<Quotes>)quoteGenerator.quotes;
            if (id < quotes.Count && id > 0)
            {
                return quotes[id];
            }
            else
            {
                return Constants.invalid;
            }
        }

    }
}
