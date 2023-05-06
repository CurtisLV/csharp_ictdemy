namespace DelegatesExercise;

internal class Sentence
{
    private string[] words;

    public Sentence(string text)
    {
        char[] chars = { '.', ',', '!', ' ', ':' };
        words = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
    }

    public override string ToString()
    {
        return String.Join(" ", words) + ".";
    }

    public void Map(Func<string, string> function)
    {
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = function(words[i]);
        }
    }

    public string Aggregate(Func<string, string, string> function)
    {
        if (words.Length == 0)
        {
            return null;
        }
        string result = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            result = function(result, words[i]);
        }
        return result;
    }
}
