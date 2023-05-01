namespace TruckUnloading;

internal class Truck
{
    int totalLoad = 0;
    int maxLoad = 3000;

    public void Load(int weight)
    {
        if (totalLoad + weight <= maxLoad)
        {
            totalLoad += weight;
        }
    }

    public void Unload(int weight)
    {
        if (totalLoad - weight >= 0)
        {
            totalLoad -= weight;
        }
    }

    public void PrintLoad()
    {
        Console.WriteLine($"Currently there is {totalLoad} kg loaded in the truck");
    }
}
