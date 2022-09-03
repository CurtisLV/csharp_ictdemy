List<string> words = new List<string>();
string answer = "";

while (answer != "end") 
{
    Console.Write("Enter a word: ");
    answer = Console.ReadLine().ToLower();
    if (answer != "end")
    {
        words.Add(answer);
    }
}

words = words.Distinct().ToList();

Console.WriteLine($"You've entered the following words: {String.Join(", ", words)}");
