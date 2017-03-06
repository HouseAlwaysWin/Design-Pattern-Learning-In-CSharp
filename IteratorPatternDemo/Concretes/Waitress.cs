
using IteratorPatternDemo.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo.Concretes
{
    public class Waitress
    {
        IEnumerable pancakeMenu;
        IEnumerable dinerMenu;

        public Waitress(IEnumerable pm, IEnumerable dm)
        {
            pancakeMenu = pm;
            dinerMenu = dm;
        }


        public void PrintMenu()
        {
            IEnumerator pancakeIterator = pancakeMenu.GetEnumerator();
            IEnumerator dinerIterator = dinerMenu.GetEnumerator();
            Console.WriteLine("MENU\n------ Breakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\n LUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                Console.WriteLine(menuItem.GetName + ", ");
                Console.WriteLine(menuItem.GetPrice + " -- ");
                Console.WriteLine(menuItem.GetDescription);
            }
        }


    }
}
