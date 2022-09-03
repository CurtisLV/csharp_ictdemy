using CarDealership;

Dealership carDealership = new Dealership("Skew street, 10", 500000);

// Create testing data
Car skoda120 = new Car("123ABC", "Škoda 120", 1000);
Car skodaFabia = new Car("456DEF", "Škoda Fabia", 10000);
Car ferrari = new Car("789GHI", "Ferrari FF", 300000);
Truck tatra = new Truck("534NGS", "Tatra 811", 5000, 20000);
Truck renault = new Truck("489GSR", "Renault Midliner", 10000, 30000);

carDealership.AddCar(skoda120);
carDealership.AddCar(skodaFabia);
carDealership.AddCar(ferrari);
carDealership.AddCar(tatra);
carDealership.AddCar(renault);

// Print statistics
Console.WriteLine($"There are {carDealership.CarCount} cars in the car dealership");
Console.WriteLine($"The car dealers have {carDealership.Money} Eur");
Console.WriteLine($"Total price of the cars is {carDealership.TotalCarValue()} Eur");
