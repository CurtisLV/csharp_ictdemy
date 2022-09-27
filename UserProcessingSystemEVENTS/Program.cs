using UserProcessingSystemEVENTS;


Database db = new Database();
EmailGen eg = new EmailGen();
IdCardGenerator id = new IdCardGenerator();


UserProcessor.UserProcesorEvent += db.SaveToDB;
UserProcessor.UserProcesorEvent += eg.SendEmail;
UserProcessor.UserProcesorEvent += id.GenerateIdCard;

Console.WriteLine("Commands accepted!");
Console.WriteLine("1. new : Add new user");
Console.WriteLine("2. exit : Close application ");

while (true)
{
    Console.Write("\nEnter command: ");
    string cmdInput = Console.ReadLine();

    if (cmdInput == "exit")
    {
        break;
    }
    else if (cmdInput == "new")
    {
        Console.Write("\nEnter username: ");
        string name = Console.ReadLine();
        Console.Write("\nEnter age: ");
        int age = Int32.Parse(s: Console.ReadLine());

        UserProcessor.ProcessUser(name, age);
    }
    else
    {
        Console.WriteLine("Invalid command!!");
    }
}
