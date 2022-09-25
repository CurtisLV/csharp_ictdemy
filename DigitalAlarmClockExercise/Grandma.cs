using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockExercise;

internal class Grandma : Human
{
    public override void WakeUp(object sender, AlarmEventProperties e)
    {
        if (e.Volume >= 20)
        {
            Console.WriteLine("Grandma wakes up");
        }
            
    }
}
