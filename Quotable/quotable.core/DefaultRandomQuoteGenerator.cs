using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace quotable.core
{
    ///Class containing the quote generator
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        public IEnumerable<string> quotes;

        ///Quote generator constructor
        ///Takes in a list of quotes as a parameter
        public DefaultRandomQuoteGenerator(IEnumerable<string> listOfQuotes){
            quotes = listOfQuotes;
        }

        ///Generates quotes from a text file called quotes.txt
        ///found in the project directory
        public static IEnumerable<string> generateQuotes(){
            List<string> list = new List<string>();
            String path = @"../quotable.core/quotes.txt";
            string[] lines = File.ReadAllLines(path);
  
            foreach (string line in lines)  {
                list.Add(line);
            }

            return list;
        }

        ///Unimplemented method implemented from interface
        public IEnumerable<string> getQuotes(long numOfQuotes){
            throw new NotImplementedException();
        }

        ///Getter for the quoteGenerator object
        public static DefaultRandomQuoteGenerator getGenerator(){
            DefaultRandomQuoteGenerator quoteGenerator = new DefaultRandomQuoteGenerator(generateQuotes());
            return quoteGenerator;
        }
    }
}
