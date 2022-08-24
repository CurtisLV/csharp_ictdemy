using Arena;

RollingDie die = new RollingDie(10);
Warrior warrior = new Warrior("Karlis", 100, 20, 10, die);

Warrior enemy = new Warrior("Shadow", 60, 18, 15, die);


Console.WriteLine(enemy.GetLastMessage());
Console.WriteLine(warrior.GetLastMessage());

Console.WriteLine($"Health after the hit {warrior.HealthBar()}");

