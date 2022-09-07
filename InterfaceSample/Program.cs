using InterfaceSample;

//IBird bird = new Bird();

//Pterodactyl pterodactyl = new Pterodactyl();


//IBird bird2 = new Pterodactyl();
//bird2.Breathe();

//((Pterodactyl)bird2).Crawl();

//IBird bird3 = new Pterodactyl();
//bird.Breathe();
//ILizard lizard = new Pterodactyl();
//lizard.Breathe();

List<Animal> animals = new List<Animal>();

//animals.Add(new Animal()); // doesn't work with Abstract classes

animals.Add(new Bird() { Weight = 1 });
animals.Add(new Dolphin() { Weight = 8 });
animals.Add(new Dolphin() { Weight = 9 });
animals.Add(new Pterodactyl() { Weight = 3 });
animals.Add(new Pterodactyl() { Weight = 2 });

// type casting with Is keyword

foreach (Animal animal in animals)
{
    Console.WriteLine(animal);
    animal.Breathe();
    if (animal is Dolphin)
    {
        ((Dolphin)animal).Jump();
    }
}


// type casting with As keyword
// difference is that if the casting fails because the object doesn't provide the given interface, the result will be null

foreach (Animal animal in animals)
{
    animal.Breathe();
    if (animal is Dolphin)
    {
        (animal as Dolphin).Jump();
    }
}

// typeof() - determine the object type

foreach (Animal animal in animals)
{
    if (animal.GetType() == typeof(Dolphin))
    {
        (animal as Dolphin).Jump();
    }
}