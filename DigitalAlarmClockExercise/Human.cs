namespace DigitalAlarmClockExercise;

internal class Human
{
    public virtual void WakeUp(object sender, AlarmEventProperties e)
    {
        Console.WriteLine("Human wakes up");
    }
}
