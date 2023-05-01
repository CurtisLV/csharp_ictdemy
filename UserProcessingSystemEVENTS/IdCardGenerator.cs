namespace UserProcessingSystemEVENTS;

public class IdCardGenerator
{
    public void GenerateIdCard(object sender, EventArgs e)
    {
        Guid id = Guid.NewGuid();
        Console.WriteLine($"ID card generated: {id}"); // unique id each time
    }
}
