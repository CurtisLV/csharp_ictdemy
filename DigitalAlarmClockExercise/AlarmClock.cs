using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockExercise;

internal class AlarmClock
{
    public event EventHandler<AlarmEventProperties> Ringing;

}
