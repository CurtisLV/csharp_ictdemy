using Arena;

RollingDie die = new RollingDie(10);

Warrior karlis = new Warrior("Karlis", 100, 20, 10, die);

//Warrior shadow = new Warrior("Shadow", 60, 18, 15, die);
Warrior gandalf = new Mage("Gandalf", 60, 15, 12, die, 30, 45);

Arena.Arena arena = new Arena.Arena(karlis, gandalf, die);

arena.Fight();

Console.ReadKey();
