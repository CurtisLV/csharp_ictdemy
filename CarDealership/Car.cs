﻿namespace CarDealership;

internal class Car
{
    private string LicensePlate { get; set; }

    private string Brand { get; }

    public int Price { get; set; }

    public Car(string licensePlate, string brand, int price)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Price = price;
    }
}
