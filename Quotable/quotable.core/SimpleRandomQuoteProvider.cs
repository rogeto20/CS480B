using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        DefaultRandomQuoteGenerator quoteGenerator = DefaultRandomQuoteGenerator.getGenerator();

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
