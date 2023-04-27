using DigitalAlarmClockExercise;

Human human = new Human();
Grandma granny = new Grandma();

AlarmClock alarm = new AlarmClock();
DigitalAlarmClock digiAlarm = new DigitalAlarmClock();

alarm.Ringing += human.WakeUp;
alarm.Ringing += granny.WakeUp;

digiAlarm.Ringing += human.WakeUp;
digiAlarm.Ringing += granny.WakeUp;

alarm.Ring();
digiAlarm.Ring();
