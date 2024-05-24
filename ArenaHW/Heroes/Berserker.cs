using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHW.Heroes
{
    internal class Berserker: Hero
    {
        public Berserker(string name, double armor, double strenght, IWeapon weapon) :
           base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            if (Health <= 12)
            {
                this.Strenght *= 2;

            }
            return base.Attack();
        }
    }
}
