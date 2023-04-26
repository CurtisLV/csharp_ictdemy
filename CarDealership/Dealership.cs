using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership;

internal class Dealership
{
    private string Address { get; set; }
    private string City { get; set; }
    public int Money { get; private set; }

    public int CarCount
    {
        get { return cars.Count; }
    }

    private List<Car> cars = new List<Car>();

    public Dealership(string address, int money)
    {
        Address = address;
        Money = money;
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void SellCar(Car car)
    {
        if (car != null && cars.Count > 0)
        {
            Money += car.Price;
            cars.Remove(car);
        }
    }

    public int TotalCarValue()
    {
        int total = 0;
        foreach (Car car in cars)
        {
            total += car.Price;
        }
        return total;
    }
}
