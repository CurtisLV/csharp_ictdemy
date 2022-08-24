using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena;

internal class Arena
{

    private Warrior warrior1;
    private Warrior warrior2;
    private RollingDie die;

    public Arena(Warrior warrior1, Warrior warrior2, RollingDie die)
    {
        this.warrior1 = warrior1;
        this.warrior2 = warrior2;
        this.die = die;
    }
}
