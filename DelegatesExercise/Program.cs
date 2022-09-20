using DelegatesExercise;

Sentence sentence = new Sentence("Delegates in C# .NET work as method references.");
sentence.Map(s => s.ToUpper());
Console.WriteLine(sentence);
