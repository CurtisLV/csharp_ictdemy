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

    public override string ToString()
    {
        string output = name + "\n";
        output += description + "\n\n";
        string directions = "";
        if (north != null)
        {
            directions += "go north\n";
        }
        if (east != null)
        {
            directions += "go east\n";
        }
        if (south != null)
        {
            directions += "go south\n";
        }
        if (west != null)
        {
            directions += "go west\n";
        }
        if (directions != null)
        {
            output += "You can: \n" + directions + "\n";
        }
        return output;
    }
}
