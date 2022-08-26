using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putni;

internal class AngryBird: Bird
{
    private int anger = 50;


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
        return $"I'm an angry-bird with a weight of {weight}, a hunger level of {hunger}, and an anger level of {anger}.";
    }


}
