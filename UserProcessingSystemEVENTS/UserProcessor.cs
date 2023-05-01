namespace UserProcessingSystemEVENTS;

public class UserProcessor
{
    public static event EventHandler<UserArgs> UserProcesorEvent;

    public static void ProcessUser(string name, int age)
    {
        UserArgs args = new UserArgs();
        args.Name = name;
        args.Age = age;

        UserProcesorEvent?.Invoke(null, args);
    }
}
