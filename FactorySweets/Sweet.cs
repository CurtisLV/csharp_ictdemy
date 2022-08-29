﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySweets;

internal class Sweet
{
    private string color;
    private string shape;
    private int weight;

    public Sweet(string color, in string shape, int weight)
    {
        this.color = color;
        this.shape = shape;
        this.weight = weight;
    }

    public override string ToString()
    {
        return $"A {shape}, {color} candy that weights {weight}g";
    }
}
