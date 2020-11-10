using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private bool NewItem;
        private double Price;
        private string Description;
        private string Category;

        public MenuItem(string category, bool newItem, double price, string description)
        {
            Category = category;
            NewItem = newItem;
            Price = price;
            Description = description;
        }

    }
}
