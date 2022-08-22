using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationGame;

internal class Location
{
    public Location north;
    public Location south;
    public Location west;
    public Location east;

    private string name;
    private string description;

    public Location(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}
