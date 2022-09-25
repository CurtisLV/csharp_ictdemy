using Events3;


Console.WriteLine("Press A button");

var key = Console.ReadLine();

if (key == "a")
{
    KeyPressed();
}

static void KeyPressed()
{
    Button button = new Button();
    button.ButtonClicked += (s, args) =>
    {
        Console.WriteLine($"You clicked a button, {args.Name}!");
    };
    button.OnClick();
}
