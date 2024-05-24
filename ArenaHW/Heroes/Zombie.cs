using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHW.Heroes
{
    internal class Zombie: Hero
    {
        public Zombie(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            Health = 120;
        }



        public override double Defend(double damage)
        {
            double currentHealth = Health;
            if (base.Defend(damage) > currentHealth && currentHealth != 1)
            {
                base.Defend(damage);
                Health = 1;
            }

            return currentHealth - Health;
        }
    }
}
