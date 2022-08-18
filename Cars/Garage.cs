using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars;

internal class Garage
{
    private Car car;

    public void Put(Car car)
    {
        this.car = car;
    }

    public override string ToString()
    {
        return $"There is a car inside: {car.GetLincesePlate()}";
    }

}
