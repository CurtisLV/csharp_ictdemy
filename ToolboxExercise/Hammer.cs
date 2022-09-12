using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxExercise;

internal class Hammer : Tool
{
    public bool IsTwoHanded { get; private set; }

    public Hammer(int weight, string name, bool isTwoHanded): base(weight, name)
    {
        IsTwoHanded = isTwoHanded;
    }

    public override void Work()
    {
        Console.WriteLine("I'm hammering");
    }
}
