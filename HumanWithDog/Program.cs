using HumanWithDog;

Dog rex = new Dog("Rex");
Console.WriteLine(rex.ToString());

Human charles = new Human("Charles", rex);
Human lucy = new Human("Lucy", rex);

charles.dog.GetOlder();
lucy.dog.GetOlder();

Console.WriteLine(rex.ToString());