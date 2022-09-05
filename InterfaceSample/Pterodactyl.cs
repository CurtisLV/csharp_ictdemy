using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal class Pterodactyl : ILizard, IBird
{
    void IBird.Breathe()
    {
        Console.WriteLine("Bird breathing sounds...");
    }

    void ILizard.Breathe()
    {
        Console.WriteLine("Lizard breathing sounds...");
    }

    public void Chirp()
    {
        Console.WriteLine("I'm crawling...");
    }

    public void Crawl()
    {
        Console.WriteLine("♫ ♫♫ ♫ ♫ ♫♫");
    }
}
