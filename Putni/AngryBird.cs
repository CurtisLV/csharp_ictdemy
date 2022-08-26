using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putni;

internal class AngryBird: Bird
{
    private int anger = 50;

    public AngryBird(int hunger, int weight, int anger): base(hunger, weight)
    {
        this.anger = anger;
    }

    public void Provoke(int infuriation)
    {
        if (hunger > 0)
        {
            anger += infuriation * 2;
        }
        else
        {
            anger += infuriation;
        }
    }

    public override string ToString()
    {
        return $"I'm a bird with a weight of {weight} and a hunger level of {hunger}, and an anger level of {anger}.";
    }


}
