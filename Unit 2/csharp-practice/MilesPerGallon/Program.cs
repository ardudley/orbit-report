using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double MilesPerGallon;
            string input;

            Console.WriteLine("Number of miles traveled: ");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("Number of gallons used: ");
            input = Console.ReadLine();
            gallons = double.Parse(input);

            MilesPerGallon = miles / gallons;
            Console.WriteLine("Your MPG is: " + MilesPerGallon);
            Console.ReadLine();
        }
    }
}
