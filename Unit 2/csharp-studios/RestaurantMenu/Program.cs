using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            var date1 = new DateTime(2020, 10, 6, 18, 30, 0);
            Console.WriteLine(date1.ToString("F"));

            MenuItem pizza = new MenuItem("Main Course", false, 4.99, "Double slice of Pepperoni or Cheese Pizza");
            MenuItem nachos = new MenuItem("Appetizeer", true, 8.99, "Nachos covered with ground beef, queso, and pico de gallo");
        }    
    }
}
