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
