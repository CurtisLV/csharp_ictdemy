using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator;

internal class SentenceGen
{
    private string[] attributes = { "blue", "big", "thin", "best", "automatic" };
    private string[] subjects = { "unicorn", "programmer", "manager", "hippopotamus", "T-rex" };
    private string[] adverbs = { "goes to", "likes to", "loves to", "learns to", "wants to" };
    private string[] verbs = { "sleep", "lay", "cook", "clean", "play" };
    private string[] advPlace = {"on the table", "in the forest", "under the desk", "at grandma's", "at work"};

    Random rand = new Random();

    private string RandWord(string[] array)
    {
        int index = rand.Next(array.Length);
        string word = array[index];
        return word;
    }

    public string Generate()
    {
        return $"{RandWord(attributes)} {RandWord(subjects)} {RandWord(adverbs)} {RandWord(verbs)} {RandWord(advPlace)}";
    }


}
