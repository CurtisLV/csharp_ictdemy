using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxExercise;

internal class Toolbox
{
    private int maxWeight;

    public int CurrentWeight { get; private set; }

    private List<Tool> tools = new List<Tool>();

    // Collection of tools just for reading, if it was public, user would be able to change the weights
    public IEnumerable<Tool> Tools
    {
        get { return tools.ToArray(); }
    }

    public Toolbox(int maxWeight) 
    {
        this.maxWeight = maxWeight;
        CurrentWeight = 1000;
    }

    public bool AddTool(Tool tool) 
    {
        // Cannot exceede max weight
        if (!(CurrentWeight + tool.Weight > maxWeight))
        {
            tools.Add(tool);
            CurrentWeight += tool.Weight;
            return true;
        }
        return false;
    }

    public bool RemoveTool(Tool tool) 
    {
        if (tools.Remove(tool))
        {
            CurrentWeight -= tool.Weight;
            return true;
        }
        return false;
    }

    public int TwoHandedHammerWeight()
    {
        int weight = 0;
        foreach (Tool tool in tools)
        {
            if (tool is Hammer && ((Hammer)tool).IsTwoHanded)
            {
                weight+= tool.Weight;
            }
        }
        return weight;
    }

}
