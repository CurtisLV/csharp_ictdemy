List<string> words = new List<string>();

Console.WriteLine("Enter a word: ");
string answer = Console.ReadLine().ToLower();

while (answer != "end") 
{
    Console.Write("Enter a word: ");
    answer = Console.ReadLine().ToLower();
    if (answer != "end")
    {
        words.Add(answer);
    }
}

Console.WriteLine("You've entered the following words: ");
foreach (string word in words) 
{

}
