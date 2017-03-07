using CompositePatternDemo.MenuAbstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo.MenuConcrete
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        public override string GetName { get; protected set; }
        public override string GetDescription { get; protected set; }

        public Menu(string name, string description)
        {
            this.GetName = name;
            this.GetDescription = description;
        }

        public override void Add(MenuComponent m)
        {
            menuComponents.Add(m);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override void Print()
        {
            Console.WriteLine("\n" + GetName);
            Console.WriteLine(", " + GetDescription);
            Console.WriteLine("--------------------");

            //IEnumerator iterator = menuComponents.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    MenuComponent menuComponent = (MenuComponent)iterator.Current;
            //    menuComponent.Print();
            //}

            foreach (var menu in menuComponents)
            {
                menu.Print();
            }
        }

    }
}
