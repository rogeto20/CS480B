using System;
using quotable.core;


namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of quotes you want:");
            int number;
            bool isNumber = int.TryParse(Console.ReadLine(), out number);

            
            while (!isNumber)
            {
                Console.WriteLine("Enter the number of quotes you want:");
                isNumber = int.TryParse(Console.ReadLine(), out number);
            }

            SimpleRandomQuoteProvider obj = new SimpleRandomQuoteProvider();
            var quotes = obj.getQuotes(number);

            foreach (string quote in quotes)
            {
                Console.WriteLine(quote);
            }

            Console.ReadKey();
        }
    }
}
