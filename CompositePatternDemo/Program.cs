using CompositePatternDemo.MenuAbstract;
using CompositePatternDemo.MenuConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu =
                new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu =
                new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu =
                new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu =
                new Menu("DESSERT MENU", "Dessert of course");


            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce ,and a slice of sourdough bread",
                true,
                3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem(
                "Apple pie",
                "Apple pit with a flakey crust, topped with vanilla ice cream",
                true,
                1.59));

            WaitressModify waitress = new WaitressModify(allMenus);

            waitress.PrintMenu();

        }
    }
}
