using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaHW.GameEngine;

namespace ArenaHW.Weapons
{
    internal class Fists: IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Fists(string name)
        {
            Name = name;
            AttackDamage = 1;
            BlockingPower = 1;
        }

        public void WeaponAbility(NotificationArgs notificationArgs)
        {

        }
    }
}
