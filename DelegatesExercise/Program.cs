using DelegatesExercise;

Sentence sentence = new Sentence("Delegates in C# .NET work as method references.");
sentence.Map(s => s.ToUpper());
Console.WriteLine(sentence);


Sentence sentence2 = new Sentence("Delegates in C# .NET work like method references.");
Console.WriteLine(sentence.Aggregate((a, b) => a + "-" + b));
