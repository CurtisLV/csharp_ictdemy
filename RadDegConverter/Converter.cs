using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadDegConverter;

internal class Converter
{
    static public double RadiansToDegrees(double rad)
    {
        // degrees = radians × 180° / π
        double deg = rad * (180 / Math.PI);
        return deg;
    }

    static public double DegreesToRadians(double deg)
    {
        // 1 rad = 180°/π = 57.295779513°
        double rad = deg / (180 / Math.PI);
        return rad;
    }
}
