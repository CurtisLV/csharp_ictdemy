using TrafficLights;

TrafficLight trafficLight = new TrafficLight();
trafficLight.Lights = ELights.Green;
Car car = new Car();

trafficLight.OnLightChange += car.ReactOnTrafficLight;

car.Run();
Console.WriteLine(car);
trafficLight.Lights = ELights.Yellow;
Console.WriteLine(car);
trafficLight.Lights = ELights.Red;
Console.WriteLine(car);
Console.ReadKey();
