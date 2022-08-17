using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator;

internal class SentenceGen
{
    private string[] attributes = {"best", "thin", "big", "best", "blue"};
    private string[] subjects = {"T-rex", "dog", "spider", "bird", "scripter"};
    private string[] adverbs = {"learns", "likes", "wants", "loves", "goes"};
    private string[] verbs = {"to cook", "to sleep", "to lay", "to clean", "to hug"};
    private string[] advPlace = {"on the table", "in the woods", "under the desk", "at grandma's", "at work"};

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
