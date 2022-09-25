using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockExercise;

internal class DigitalAlarmClock : AlarmClock
{
    public override void Ring()
    {
        Console.WriteLine("Digialarm went off");
        OnRingEvent(20);
    }
}
