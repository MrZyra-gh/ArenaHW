using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaHW.GameEngine;

namespace ArenaHW.Weapons
{
    internal class Sword: IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }

        public void WeaponAbility(NotificationArgs notificationArgs)
        {

        }
    }
}
