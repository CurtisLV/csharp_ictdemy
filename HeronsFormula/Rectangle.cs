using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsFormula;

internal class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height, string color)
        : base(color)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}
