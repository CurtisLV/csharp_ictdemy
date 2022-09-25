using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockExercise;

internal class Human
{
    public virtual void WakeUp(object sender, AlarmEventProperties e)
    {
        Console.WriteLine("Human wakes up");
    }
}
