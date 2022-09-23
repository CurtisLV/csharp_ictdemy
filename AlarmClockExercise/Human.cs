using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockExercise;

internal class Human
{
    public enum EState
    {
        Up, Sleeping
    }

    public EState State { get; private set; }

    public event EventHandler SleepStatus;

    public Human()
    {
        State = EState.Sleeping;
    }

    public void WakeUp()
    {
    }

}   


