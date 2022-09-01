using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLottery;

internal class Lottery
{
    private List<int> numbers;
    private Random random;

    public Lottery()
    {
        random = new Random();
        numbers = new List<int>();
    }
}
