using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars;

internal class Car
{
    private string licensePlate;
    private string color;

    public Car(string licensePlate, string color)
    {
        this.licensePlate = licensePlate;
        this.color = color;

    }

    public string GetLincesePlate()
    {
        return licensePlate;
    }

    public void Park(Garage garage)
    {
        garage.Put(this);
    }

}
