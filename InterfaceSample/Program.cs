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

animals.Add(new Bird() { Weight = 1 });
animals.Add(new Dolphin() { Weight = 8 });
animals.Add(new Dolphin() { Weight = 9 });
animals.Add(new Pterodactyl() { Weight = 3 });
animals.Add(new Pterodactyl() { Weight = 2 });

foreach (Animal animal in animals)
{
    Console.WriteLine(animal);
    animal.Breathe();
    if (animal is Dolphin)
    {
        ((Dolphin)animal).Jump();
    }
}
    
