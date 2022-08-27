using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsFormula;

internal class Rectangle: Shape
{
    private double width;
    private double height;

    public Rectangle(string color, double width, double height): base (color)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}
