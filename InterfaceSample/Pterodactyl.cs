using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal class Pterodactyl : ILizard, IBird
{
    public void Breathe()
    {
        Console.WriteLine("I'm crawling...");
    }

    public void Chirp()
    {
        Console.WriteLine("I'm breathing...");
    }

    public void Crawl()
    {
        Console.WriteLine("♫ ♫♫ ♫ ♫ ♫♫");
    }
}
