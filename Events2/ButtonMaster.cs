namespace Events2;

internal class ButtonMaster
{
    public event EventHandler<ButtonPressedEventsArgs>? ButtonPressed;

    public void OnButtonPress(char keyCode)
    {
        ButtonPressed?.Invoke(this, new ButtonPressedEventsArgs(keyCode));
    }
}

public class ButtonPressedEventsArgs
{
    public char KeyCode { get; }

    public ButtonPressedEventsArgs(char keyCode)
    {
        KeyCode = keyCode;
    }
}
