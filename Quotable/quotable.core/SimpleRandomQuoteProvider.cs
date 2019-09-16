using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    ///Class providing random quotes
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        DefaultRandomQuoteGenerator quoteGenerator = DefaultRandomQuoteGenerator.getGenerator();

        ///Returns a number of quotes depending on the number
        ///passed in as a parameter
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
    }
}
