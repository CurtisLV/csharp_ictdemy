using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights;

internal class Car
{
    private int speed = 0;

    public void Run()
    {
        speed = 100;
    }

    public void ReactOnTrafficLight(Object sender, EventArgs e)
    {

    }
}
