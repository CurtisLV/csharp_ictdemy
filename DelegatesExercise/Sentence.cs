using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExercise;

internal class Sentence
{

    private string[] words;

    public Sentence(string text)
    {
        char[] chars = ['.', ',', '!', ' ', ':'];  
        words = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
    }

    public override string ToString()
    {
        return String.Join(" ", words) + ".";
    }
}
