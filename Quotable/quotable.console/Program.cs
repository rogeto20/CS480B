using System;
using System.Collections.Generic;
using System.Text;
using quotable.core;


namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of quotes you want:");
            long numberOfQuotes;
            bool isInteger = long.TryParse(Console.ReadLine(), out numberOfQuotes);

            
            while (!isInteger)
            {
                Console.WriteLine("Invalid input. Please type in an integer with the number of quotes you want:");
                isInteger = long.TryParse(Console.ReadLine(), out numberOfQuotes);
            }

            SimpleRandomQuoteProvider randomQuoteProvider = new SimpleRandomQuoteProvider(Constants.LocalFilePath);
            List<Quotes> quotes = (List<Quotes>)randomQuoteProvider.getQuotes(numberOfQuotes);

            foreach (Quotes quote in quotes)
            {
                Console.WriteLine(quote.Quote);
            }

            Console.ReadKey();
        }
    }
}
