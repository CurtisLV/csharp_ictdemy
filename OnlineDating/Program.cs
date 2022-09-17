using OnlineDating;

List<User> users = new List<User>();

users.Add(new User("Charles", "New", Sex.Male, new DateTime(1958, 6, 25), EyeColor.Green, HairColor.Blond));
users.Add(new User("Josef", "New", Sex.Male, new DateTime(1978, 3, 19), EyeColor.Brown, HairColor.Brown));
users.Add(new User("Jan", "Marek", Sex.Male, new DateTime(1968, 4, 28), EyeColor.Black | EyeColor.Brown, HairColor.NotSpecified));
users.Add(new User("Charles", "New", Sex.Male, new DateTime(1958, 6, 25), EyeColor.Green, HairColor.Blond));
users.Add(new User("Marie", "New", Sex.Female, new DateTime(1988, 8, 15), EyeColor.Blue, HairColor.Black));
users.Add(new User("Lucy", "Novak", Sex.Female, new DateTime(1978, 10, 2), EyeColor.Cyan, HairColor.Blond));
users.Add(new User("Simon", "Young", Sex.Female, new DateTime(1968, 1, 8), EyeColor.NotSpecified, HairColor.Brown));
users.Add(new User("Michael", "Futigue", Sex.Female, new DateTime(1958, 12, 6), EyeColor.Blue, HairColor.Ginger));


users = users.Distinct().ToList();

foreach (User user in users)
{
    Console.WriteLine(user);
}


