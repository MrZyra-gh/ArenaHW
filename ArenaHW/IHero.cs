using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHW
{
    internal interface IHero
    {
        double Attack();
        double Defend(double damage);
    }
}
