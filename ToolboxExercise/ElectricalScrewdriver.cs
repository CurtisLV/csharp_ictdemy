using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxExercise;

internal class ElectricalScrewdriver : Screwdriver
{
    public int BatteryLevel { get; private set; }

    public ElectricalScrewdriver(int weight, string name, int batteryLevel)
        : base(weight, name)
    {
        BatteryLevel = batteryLevel;
    }

    public override void Work()
    {
        base.Work();
    }
}
