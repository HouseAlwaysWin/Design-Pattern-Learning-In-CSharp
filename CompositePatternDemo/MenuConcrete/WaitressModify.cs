using CompositePatternDemo.MenuAbstract;
using IteratorPatternDemo.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo.MenuConcrete
{
    public class WaitressModify
    {
        MenuComponent allMenus;
        public WaitressModify(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}
