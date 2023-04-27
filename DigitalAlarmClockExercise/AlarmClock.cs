namespace DigitalAlarmClockExercise;

internal class AlarmClock
{
    public event EventHandler<AlarmEventProperties> Ringing;

    public void OnRingEvent(int volume)
    {
        Ringing(this, new AlarmEventProperties(volume));
    }

    public virtual void Ring()
    {
        Console.WriteLine("The alarm went off");
        OnRingEvent(10);
    }
}
