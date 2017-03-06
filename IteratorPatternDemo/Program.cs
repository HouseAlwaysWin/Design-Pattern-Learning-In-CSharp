using IteratorPatternDemo.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pm = new PancakeHouseMenu();
            DinerMenu dm = new DinerMenu();

            Waitress w = new Waitress(pm, dm);
            w.PrintMenu();



        }
    }
}
