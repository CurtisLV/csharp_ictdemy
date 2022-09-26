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

}
