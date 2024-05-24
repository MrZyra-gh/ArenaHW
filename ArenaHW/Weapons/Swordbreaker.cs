using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaHW.GameEngine;

namespace ArenaHW.Weapons
{
    internal class Swordbreaker: IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Swordbreaker(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 14;
        }

        public void WeaponAbility(NotificationArgs notificationArgs)
        {
            Random random = new Random();
            double probability = random.NextDouble();
            if (probability < 0.07)
            {
                notificationArgs.Defender.Weapon = new Fists("fists");
            }
        }
    }
}
