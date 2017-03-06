
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo.Concretes
{
    public class MenuItem
    {
        public string GetName { get; private set; }
        public string GetDescription { get; private set; }
        public bool GetVegetarian { get; private set; }
        public double GetPrice { get; private set; }




        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            GetName = name;
            GetDescription = description;
            GetVegetarian = vegetarian;
            GetPrice = price;
        }

    }
}
