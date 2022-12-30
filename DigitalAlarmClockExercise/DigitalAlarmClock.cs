namespace DigitalAlarmClockExercise;

internal class DigitalAlarmClock : AlarmClock
{
    public override void Ring()
    {
        Console.WriteLine("Digialarm went off");
        OnRingEvent(20);
    }
}
