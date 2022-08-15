using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena;
/// <summary>
/// Class representing a die for a board game
/// </summary>
internal class RollingDie
{
    private Random random;
    private int sidesCount;

    public RollingDie(int iSidesCount)
    {
        sidesCount = iSidesCount;
        random = new Random();
    }    
    public RollingDie()
    {
        sidesCount = 6;
        random = new Random();
    }

    public int GetSidesCount()
    {
        return sidesCount;
    }


}
