using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockExercise;

internal class AlarmClock
{
    public event EventHandler<AlarmEventProperties> Ringing;

    public void OnRingEvent(int volume)
    {
        Ringing?.Invoke(this, new AlarmEventProperties(volume));
    }

    public virtual void Ring()
    {
        Console.WriteLine("The alarm went off");
        OnRingEvent(10);
    }

}
