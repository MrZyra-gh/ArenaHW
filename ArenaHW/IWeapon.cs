using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaHW.GameEngine;

namespace ArenaHW
{
    internal interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; }
        double BlockingPower { get; }

        void WeaponAbility(GameEngine.NotificationArgs args);
    }
}
