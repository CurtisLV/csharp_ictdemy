using Arena;

RollingDie die = new RollingDie(10);

Warrior karlis = new Warrior("Karlis", 100, 20, 10, die);
Warrior shadow = new Warrior("Shadow", 60, 18, 15, die);

Arena.Arena arena = new Arena.Arena(karlis, shadow, die);

arena.Fight();

