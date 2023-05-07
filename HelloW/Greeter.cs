namespace HelloW
{
    /// <summary>
    /// A class represents a greeter whose purpose is to greet the user
    /// </summary>
    internal class Greeter
    {
        public string? text;

        public string Greet(string name = "World")
        {
            return $"{text}, {name}!";
        }
    }
}
