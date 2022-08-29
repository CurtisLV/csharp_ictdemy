using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice2;

internal class RollingDice
{
    private static Random random = new Random();

    public int Throw()
    {
        return random.Next(6) + 1;
    }


}
