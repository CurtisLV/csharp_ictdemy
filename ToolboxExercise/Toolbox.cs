using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxExercise;

internal class Toolbox
{
    public int MaxWeight { get; private set; }

    public int MaxTools { get; private set; }

    public int CurrentWeight { get; private set; }

    private List<Tool> tools = new List<Tool>();

    public Toolbox(int maxWeight, int maxTools, int currentWeight, List<Tool> tools)
    {
        MaxWeight = maxWeight;
        MaxTools = maxTools;
        CurrentWeight = currentWeight;
        this.tools = tools;
    }

    public void AddTool(Tool tool) 
    {
        tools.Add(tool);
    }

    public void RemoveTool(Tool tool) 
    {
        tools.Remove(tool);
    }

}
