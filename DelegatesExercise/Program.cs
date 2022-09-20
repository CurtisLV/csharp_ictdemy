using DelegatesExercise;

Sentence sentence = new Sentence("Delegate in C# .NET work like method reference.");
sentence.Map(s => (s.Length > 5) ? s.ToUpper() : s);
Console.WriteLine(sentence);


string aggregate1 = sentence.Aggregate((a,b) => a + " " + b);

Console.WriteLine(aggregate1);

string aggregate2 = sentence.Aggregate((a, b) => "(" + a + ") " + b);
Console.WriteLine(aggregate2);
string aggregate3 = sentence.Aggregate((a,b) => a + " " + ((b.Length > 4) ? b.Substring(0, 3) + "." : b));
Console.WriteLine(aggregate3);

