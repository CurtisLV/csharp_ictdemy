using LocationGame;

Console.WriteLine("You are standing at the forest crossroads.");

World world = new World();

string command = "";

while (command.ToLower() != "end")
{
    Console.WriteLine(world.ReturnCurrentLocation());
    Console.Write("Enter command: ");
    command = Console.ReadLine();
    world.ProcessCommand(command);
}