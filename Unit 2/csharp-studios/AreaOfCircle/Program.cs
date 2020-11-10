using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius.");
            string userInput = Console.ReadLine();
            double radius = double.Parse(userInput);
            double area = Math.Pow(radius, 2.0) * Math.PI;
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area + ".");
            Console.WriteLine("The circumference is " + circumference + ".");
            Console.WriteLine("The diameter is " + diameter + ".");

            Console.WriteLine("Enter your vehicle's MPG.");
            userInput = Console.ReadLine();
            double mpg = double.Parse(userInput);

            double gallons = area / mpg;
            Console.WriteLine("You will use " + gallons + " gallons to travel the circle.");


        }
    }
}
