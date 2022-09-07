using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal class Lizard: Animal, ILizard
{
    public void Crawl()
    {
        Console.WriteLine("Crawling...");
    }

    public override void Move()
    {
        Console.WriteLine("Crawling...");
    }

}
