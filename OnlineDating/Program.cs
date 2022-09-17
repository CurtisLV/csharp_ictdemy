using OnlineDating;

List<User> users = new List<User>();

users.Add(new User("Charles", "New", new DateTime(1958, 12, 12), Sex.Male, EyeColor.Green, HairColor.Blonde));

foreach (User user in users)
{
    Console.WriteLine(user);
}


