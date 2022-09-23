using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockExercise;
public delegate void Ringing();

internal class Clock
{

    public event Ringing Ringing;

    public void Ring()
    {
        if (Ringing != null)
        {
            Ringing();
        }
    }

}
