using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your vehicle's MPG.");
            string userInput = Console.ReadLine();
            double mpg = double.Parse(userInput);
        }
    }
}
