using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationGame;

internal class World
{
    private Location currentLocation;

    public World()
    {
        Location castle = new Location(
            "Castle",
            "You're standing in front of gate of gothic castle which is probably the only entrance into the fortress. The keyhole is covered in cobwebs which gives an impression that the building is abandoned."
        );
        Location forest1 = new Location(
            "Forest",
            "You're on a forest path which winds up on the horizon dissapearing in sunset. The silence of evening forest is sometimes interrupted by bird singing."
        );
        Location forest2 = new Location(
            "Forest crossroads",
            "You're standing at forest crossroads."
        );
        Location forest3 = new Location(
            "Forest",
            "You're on a forest path which winds up on the horizon dissapearing in sunset. The silence of evening forest is sometimes interrupted by bird singing."
        );
        Location pond = new Location(
            "Pond",
            "You've reached shore of a small pond. The pond is in calm as a mirror. There is a wooden platform with floodgate nearby."
        );
        Location forest4 = new Location(
            "Forest",
            "You're on a forest path which winds up on the horizon dissapearing in sunset. The silence of evening forest is sometimes interrupted by bird singing."
        );
        Location house = new Location(
            "House",
            "You're standing in front of your birth house. You can smell the freshly cut wood from a pile beside the entrance door."
        );

        // link all locations
        castle.east = forest1;
        forest1.west = castle;
        forest1.east = forest2;
        forest2.west = forest1;
        forest2.east = forest3;
        forest2.south = forest4;
        forest3.west = forest2;
        forest3.east = pond;
        forest4.east = house;
        forest4.north = forest2;
        pond.west = forest3;
        house.west = forest4;

        currentLocation = house;
    }

    public void ProcessCommand(string command)
    {
        // command to lower
        command = command.ToLower();
        // if starts with go, check if ends with correct
        if (command.StartsWith("go"))
        {
            // if currentLocation.side != null
            if (command.EndsWith("north") && currentLocation.north != null)
            {
                currentLocation = currentLocation.north;
            }
            else if (command.EndsWith("east") && currentLocation.east != null)
            {
                currentLocation = currentLocation.east;
            }
            else if (command.EndsWith("south") && currentLocation.south != null)
            {
                currentLocation = currentLocation.south;
            }
            else if (command.EndsWith("west") && currentLocation.west != null)
            {
                currentLocation = currentLocation.west;
            }
            else
            {
                Console.WriteLine("You cannot go this way.");
            }
        }
        else if (command != "end")
        {
            // else dont recognize the command
            Console.WriteLine("I cannot recognize this command.");
        }
    }

    public Location ReturnCurrentLocation()
    {
        return currentLocation;
    }
}
