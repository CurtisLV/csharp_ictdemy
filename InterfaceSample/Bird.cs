using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal class Bird
{
    public void Chirp()
    {
        Console.WriteLine("♫ ♫ ♫");
    }

    public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }

    public void Peck()
    {
        Console.WriteLine("Peck, peck!");
    }

}
