namespace CarDealership;

internal class Truck : Car
{
    private int CargoCapacity { get; }

    public Truck(string licensePlate, string brand, int price, int cargoCapacity)
        : base(licensePlate, brand, price)
    {
        CargoCapacity = cargoCapacity;
    }
}
