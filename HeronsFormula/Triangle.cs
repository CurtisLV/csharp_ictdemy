using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsFormula;

internal class Triangle : Shape
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c, string color)
        : base(color)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Area()
    {
        double s = (a + b + c) / 2;

        double bigS = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return bigS;
    }
}
