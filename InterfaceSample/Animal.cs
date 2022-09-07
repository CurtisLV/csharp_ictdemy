using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal abstract class Animal
{
    public int Weight {
        get; set;
    }

    virtual public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }

    public abstract void Move(); // Abstract method

}
