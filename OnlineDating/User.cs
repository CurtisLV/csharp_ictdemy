﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDating;

internal class User
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime Birthdate { get; private set; }

    public enum Sex
    {
        Male, Female
    };

    [Flags]
    public enum EyeColor
    {
        NotSpecified = 0, 
        Blue = 1, 
        Green = 2, 
        Brown = 4, 
        Black = 8, 
        Cyan = 3, 
        Browngreen = 6
    }
}
