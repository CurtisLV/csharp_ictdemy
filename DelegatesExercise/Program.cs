using DelegatesExercise;

Sentence sentence = new Sentence("Delegate in C# .NET work like method reference.");
sentence.Map(s => (s.Length > 5) ? s.ToUpper() : s);
Console.WriteLine(sentence);

string aggregate1 = sentence.Aggregate((a, b) => a + " " + b);
string aggregate2 = sentence.Aggregate((a, b) => "(" + a + ") " + b);
string aggregate3 = sentence.Aggregate(
    (a, b) => a + " " + ((b.Length > 4) ? b.Substring(0, 3) + "." : b)
);

Console.WriteLine($"Aggregates: \n{aggregate1}\n{aggregate2}\n{aggregate3}");

string aggregate4 = sentence.Aggregate(
    (a, b) => a + " yOlO " + ((b.Length > 5) ? b.ToLower() : b.ToUpper())
);
Console.WriteLine(aggregate4);
