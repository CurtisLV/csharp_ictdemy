namespace Events3;

internal class Button
{
    public event EventHandler<MyCustomArguments> ButtonClicked;

    public void OnClick()
    {
        MyCustomArguments args = new MyCustomArguments();
        args.Name = "Ian";
        ButtonClicked.Invoke(this, args);
    }
}

public class MyCustomArguments : EventArgs
{
    public string Name { get; set; }
}
