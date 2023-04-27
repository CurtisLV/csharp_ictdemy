namespace DigitalAlarmClockExercise;

public class AlarmEventProperties : EventArgs
{
    public int Volume { get; set; }

    public AlarmEventProperties(int volume)
    {
        Volume = volume;
    }
}
