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

    public IEnumerable<Tool> Tools
    {
        get { return tools.ToArray(); }
    }

    public Toolbox(int maxWeight) 
    {
        this.maxWeight = maxWeight;
        CurrentWeight = 1000;
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
