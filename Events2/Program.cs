using Events2;

var buttonMaster = new ButtonMaster();

buttonMaster.ButtonPressed += (sender, eventArgs) =>
{
    Console.WriteLine("Button was pressed");
};

Start:

var keyCode = Console.ReadKey(true).KeyChar;
buttonMaster.OnButtonPress(keyCode);

goto Start;