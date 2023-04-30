namespace ToolboxExercise;

internal class Screwdriver : Tool
{
    public Screwdriver(int weight, string name)
        : base(weight, name) { }

    public override void Work()
    {
        Console.WriteLine("I'm screwing");
    }
}
