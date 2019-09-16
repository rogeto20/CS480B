using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace quotable.core
{
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        public IEnumerable<string> quotes;
        public DefaultRandomQuoteGenerator(IEnumerable<string> listOfQuotes){
            quotes = listOfQuotes;
        }

        public static IEnumerable<string> generateQuotes(){
            List<string> list = new List<string>();
            String path = @"../quotable.core/quotes.txt";
            string[] lines = File.ReadAllLines(path);
  
            foreach (string line in lines)  {
                list.Add(line);
            }

            return list;
        }
        public IEnumerable<string> getQuotes(long numOfQuotes){
            return null;
        }

        public static DefaultRandomQuoteGenerator getGenerator(){
            DefaultRandomQuoteGenerator quoteGenerator = new DefaultRandomQuoteGenerator(generateQuotes());
            return quoteGenerator;
        }
    }
}
