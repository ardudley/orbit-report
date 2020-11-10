using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input1;
            string input2;

            Console.WriteLine("What is the rectangle's length?");
            input1 = Console.ReadLine();
            length = double.Parse(input1);

            Console.WriteLine("What is the rectangle's width?");
            input2 = Console.ReadLine();
            width = double.Parse(input2);

            area = length * width;
            Console.WriteLine("The area of the rectange is: " + area);
            Console.ReadLine();

        }
    }
}
