using ComparingAndOperator;

List<Human> people = new List<Human>();

Man charles = new Man("Charles", "New", new DateTime(1988, 2, 5));
people.Add(charles);
people.Add(new Man("Josef", "New", new DateTime(1978, 3, 19)));
people.Add(new Man("Jan", "Marek", new DateTime(1968, 4, 28)));
people.Add(new Man("Charles", "New", new DateTime(1958, 6, 25)));
Woman marie = new Woman("Marie", "New", new DateTime(1988, 8, 15));
people.Add(marie);
people.Add(new Woman("Lucy", "New", new DateTime(1978, 10, 2)));
people.Add(new Woman("Simon", "Young", new DateTime(1968, 1, 8)));
people.Add(new Woman("Michael", "Futile", new DateTime(1958, 12, 6)));

people.Sort(); // Sorting the people
foreach (Human c in people) // Printing the people
{
    Console.WriteLine(c);
}
Console.WriteLine();

// Creating a child
Human dite = charles + marie;
Console.WriteLine($"{charles} and {marie} have a child named {dite}");
