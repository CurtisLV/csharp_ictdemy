using RollDice2;

RollingDice d1 = new RollingDice();
RollingDice d2 = new RollingDice();

for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"The first die rolled a\t{d1.Throw()}");
    Console.WriteLine($"The second die rolled a\t{d2.Throw()}");
}