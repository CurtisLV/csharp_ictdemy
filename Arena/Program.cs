using Arena;

RollingDie dieSix = new RollingDie();
RollingDie dieTen = new RollingDie(10);

Console.WriteLine(dieSix.GetSidesCount());
Console.WriteLine(dieTen.GetSidesCount());

Console.WriteLine(dieSix);

