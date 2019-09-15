using System;
using quotable.core;


namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of quotes you want:");
            long numOfQuotes;
            bool isNumber = long.TryParse(Console.ReadLine(), out numOfQuotes);

            
            while (!isNumber)
            {
                Console.WriteLine("Enter the number of quotes you want:");
                isNumber = long.TryParse(Console.ReadLine(), out numOfQuotes);
            }

            SimpleRandomQuoteProvider obj = new SimpleRandomQuoteProvider();
            var quotes = obj.getQuotes(numOfQuotes);

            foreach (string quote in quotes)
            {
                Console.WriteLine(quote);
            }

            Console.ReadKey();
        }
    }
}
