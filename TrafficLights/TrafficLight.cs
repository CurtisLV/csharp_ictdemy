﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights;

public enum ELights
{
    Green,
    Yellow,
    Red
}

class TrafficLight
{
    public event EventHandler OnLightChange;
    private ELights lights;
    public ELights Lights
    {
        get { return lights; }
        set
        {
            lights = value;
            Console.WriteLine($"{lights} light");
            OnLightChangeEvent();
        }
    }

    public void OnLightChangeEvent()
    {
        if (OnLightChange != null)
        {
            OnLightChange(this, EventArgs.Empty);
        }
    }
}
