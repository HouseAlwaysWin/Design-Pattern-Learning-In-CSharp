
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo.Concretes
{
    public class PancakeHouseMenu : IEnumerable
    {
        ArrayList menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();


            AddItem("K&B's Pancake Breakfast", "Pancakes with scrabmled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, and sausage", false, 2.99);
            AddItem("Blueberry Pancake Breakfast", "Pancakes with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blue berries or strawberries ", true, 3.59);
        }

        public void AddItem(
            string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }



        public IEnumerator GetEnumerator()
        {
            return menuItems.GetEnumerator();
        }
    }

}
