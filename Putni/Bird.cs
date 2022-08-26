using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putni;

internal class Bird
{
    protected int hunger = 100;
    protected int weight = 50;

    public void Eat(int foodWeight)
    {
        hunger -= foodWeight;
        if (hunger < 0)
        {
            hunger = 0;
        }

        weight += foodWeight;
    }

    public override string ToString()
    {
        return $"I'm a bird with a weight of {weight} and a hunger level of {hunger}.";
    }
}
