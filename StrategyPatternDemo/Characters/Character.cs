using StrategyPatternDemo.Beheaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo.Characters
{
    public class Character
    {
        private IWeaponBehavior weaponBehavior;
        public Character()
        {
            weaponBehavior = new SwordBehavior();
        }
        public void fight()
        {
            Console.WriteLine("Fighting");
        }

        public void SetWeaponBehavior(IWeaponBehavior wp)
        {
            weaponBehavior = wp;
        }

        public void UseWeapon()
        {
            weaponBehavior.UseWeapon();
        }
    }
}
