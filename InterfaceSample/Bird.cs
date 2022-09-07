using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal class Bird: Animal, IBird
{
    public void Chirp()
    {
        Console.WriteLine("♫ ♫ ♫");
    }

    public void Peck()
    {
        Console.WriteLine("Peck, peck!");
    }

    public override void Move()
    {
        Console.WriteLine("Flying...");
    }

}
