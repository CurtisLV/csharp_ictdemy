namespace Friends;

internal class Person
{
    public string name;
    public int age;
    public Person friend;

    public void Introduce()
    {
        Console.WriteLine(
            $"Hi, my name is {name}, I'm {age} years old and my friend is {friend.name}"
        );
    }
}
