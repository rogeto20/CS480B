using System;


namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of quotes you want:");
            //int num;
            //bool isNumber = int.TryParse(Console.ReadLine(), out num);

            int num = int.Parse(Console.ReadLine());

            var obj = new SimpleRandomQuoteProvider();
        }
    }
}
