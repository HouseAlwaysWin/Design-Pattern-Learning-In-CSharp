using StrategyPatternDemo.Beheaviors;
using StrategyPatternDemo.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.UseWeapon();
            king.SetWeaponBehavior(new AxeBehavior());
            king.UseWeapon();
        }
    }
}
