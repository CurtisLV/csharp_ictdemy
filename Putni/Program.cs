using Putni;

Bird bird = new Bird();
AngryBird angryBird = new AngryBird();

Console.WriteLine(bird);
Console.WriteLine(angryBird);

bird.Eat(50);
angryBird.Eat(50);

Console.WriteLine(bird);
Console.WriteLine(angryBird);

bird.Eat(25);
angryBird.Provoke(5);

Console.WriteLine(bird);
Console.WriteLine(angryBird);
