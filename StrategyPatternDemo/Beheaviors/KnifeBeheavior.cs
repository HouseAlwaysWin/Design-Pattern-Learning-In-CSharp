using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo.Beheaviors
{
    class KnifeBeheavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use KnifeBeheavior");
        }
    }
}
