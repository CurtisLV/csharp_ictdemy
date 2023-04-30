namespace ToolboxExercise;

internal class Saw : Tool
{
    public Saw(int weight, string name)
        : base(weight, name) { }

    public override void Work()
    {
        Console.WriteLine("I'm sawing");
    }
}
