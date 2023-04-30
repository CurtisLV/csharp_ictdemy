using ToolboxExercise;

// Create the toolbox
Toolbox toolbox = new Toolbox(10000);
Console.WriteLine(toolbox);

// Place the tools inside the toolbox
toolbox.AddTool(new Hammer(1200, "Small hammer", false));
toolbox.AddTool(new Hammer(3000, "Big hammer", true));
toolbox.AddTool(new Hammer(4000, "Demolition hammer", true));
toolbox.AddTool(new Screwdriver(800, "Philips screwdriver"));
toolbox.AddTool(new Saw(2500, "Rusty sawmill"));
toolbox.AddTool(new ElectricalScrewdriver(1800, "Bosh electric screwdriver", 4000));

Console.WriteLine(toolbox);

// Let the tools work (everyone's dreem)
foreach (Tool n in toolbox.Tools)
{
    n.Work();
}

// Calculate weight of all two-handed hammers
Console.WriteLine(
    $"The weight of the two-handed hammers is {toolbox.TwoHandedHammerWeight()} grams"
);

Console.ReadKey();
