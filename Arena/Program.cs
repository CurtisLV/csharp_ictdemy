using Arena;

//RollingDie dieSix = new RollingDie();
//RollingDie dieTen = new RollingDie(10);

//// Rolls the 6-sided die
//Console.WriteLine(dieSix);
//for (int i = 0; i < 10; i++) 
//{
//    Console.Write(dieSix.Roll() + " ");
//}


//// Rolls the 10-sided die
//Console.WriteLine("\n\n" + dieTen);
//for (int i = 0; i < 10; i++)
//{
//    Console.Write(dieTen.Roll() + " ");
//}

RollingDie die = new RollingDie(10);
Warrior warrior = new Warrior("Karlis", 100, 20, 10, die);

Console.WriteLine($"Warrior: {warrior}"); // test ToString();

// test Alive()

Console.WriteLine($"Warrior is live: {warrior.Alive()}");

// test HealthBar()
Console.WriteLine($"Warrior's health bar: {warrior.HealthBar()}");

//// test Attack()
//warrior.Attack(warrior);

Warrior enemy = new Warrior("Shadow", 60, 18, 15, die);
enemy.Attack(warrior);

Console.WriteLine(enemy.GetLastMessage());
Console.WriteLine(warrior.GetLastMessage());

Console.WriteLine($"Health after the hit {warrior.HealthBar()}");

