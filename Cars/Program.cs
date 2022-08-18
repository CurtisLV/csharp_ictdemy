using Cars;

Car bmw = new Car("123ABC", "red");

Garage garage = new Garage();

garage.Put(bmw);

Console.WriteLine(garage.ToString());
