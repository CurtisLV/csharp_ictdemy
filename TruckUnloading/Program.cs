using TruckUnloading;

Truck truck = new Truck();

truck.Load(1000);
truck.PrintLoad();
truck.Load(500);
truck.PrintLoad();
truck.Unload(300);
truck.PrintLoad();
truck.Unload(1000);
truck.PrintLoad();
