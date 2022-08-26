using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putni;

internal class Bird
{
    protected int hunger;
    protected int weight;

    public Bird(int hunger, int weight)
    {
        this.hunger = hunger;
        this.weight = weight;
    }

    public void Eat(int foodWeight)
    {
        hunger -= foodWeight;
        if (hunger < 0)
        {
            hunger = 0;
        }

        weight += foodWeight;
    }
}
