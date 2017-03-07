using CompositePatternDemo.MenuAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo.MenuConcrete
{
    public class MenuItem : MenuComponent
    {
        public override string GetName
        {
            get; protected set;
        }
        public override string GetDescription { get; protected set; }
        public override bool IsVegetarian
        {
            get; protected set;
        }

        public override double GetPrice { get; protected set; }

        public MenuItem(string name,
            string description,
            bool vegetarian,
            double price)
        {
            this.GetName = name;
            this.GetDescription = description;
            this.IsVegetarian = vegetarian;
            this.GetPrice = price;
        }


        public override void Print()
        {
            Console.WriteLine(" " + GetName);
            if (IsVegetarian)
            {
                Console.WriteLine("(v)");
            }

            Console.WriteLine(", " + GetPrice);
            Console.WriteLine("  -- " + GetDescription);
        }




    }
}
