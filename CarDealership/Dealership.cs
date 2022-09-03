using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership;

internal class Dealership
{
    private string Address {
        get; set;
    }
    private string City {
        get; set;
    }
    private int Money {
        get; set;
    }

    public int CarCount{
        get {
            return cars.Count;
        }
    }

    private List<Car> cars = new List<Car>();

    public Dealership(string address, int money)
    {
        Address = address;
        Money = money;
    }
}
