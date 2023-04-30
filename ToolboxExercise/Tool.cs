using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxExercise;

internal abstract class Tool
{
    public int Weight { get; private set; }
    public string Name { get; private set; }

    public Tool(int weight, string name)
    {
        Weight = weight;
        Name = name;
    }

    public abstract void Work();

    public override string ToString()
    {
        return Name;
    }
}
