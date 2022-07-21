using System;

namespace WhileLoops_BusPPLCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by 1 or any other key to finish counting");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine($"Current people count is {counter}");
            }
            Console.WriteLine($"{counter} people are inside the bus, count finished");
            Console.Read();

        }
    }
}
