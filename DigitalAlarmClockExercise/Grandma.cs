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
