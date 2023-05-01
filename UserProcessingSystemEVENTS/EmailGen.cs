namespace UserProcessingSystemEVENTS;

public class EmailGen
{
    public void SendEmail(object sender, UserArgs e)
    {
        Console.WriteLine($"Email sent to {e.Name}!");
    }
}
