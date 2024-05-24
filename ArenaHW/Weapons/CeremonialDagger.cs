using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaHW.GameEngine;

namespace ArenaHW.Weapons
{
    internal class CeremonialDagger : Dagger
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public CeremonialDagger(string name):
            base(name) {
            AttackDamage = 15;
            BlockingPower = 1;
        }
        

        public override void WeaponAbility(NotificationArgs notificationArgs)
        {
            if (notificationArgs.Attacker.Health > 10)
            {
                notificationArgs.Attacker.Health -= 10;
                notificationArgs.Attacker.Strenght += 12;
            }
        }
    }
}
