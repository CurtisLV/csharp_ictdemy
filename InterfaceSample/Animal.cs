using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal class Animal
{
    public int Weight {
        get; set;
    }

    public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }
}
