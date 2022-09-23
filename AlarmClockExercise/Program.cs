using AlarmClockExercise;

Human human = new Human();
Clock clock = new Clock();

clock.Ringing += human.WakeUp;

Console.WriteLine("The alarm went off");
clock.Ring();
