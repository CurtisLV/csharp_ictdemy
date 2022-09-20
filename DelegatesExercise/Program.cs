using DelegatesExercise;

Sentence sentence = new Sentence("Delegates in C# .NET work as method references.");
sentence.Map(s => (s.Length > 5) ? s.ToUpper() : s);
Console.WriteLine(sentence);


string aggregate1 = sentence.Aggregate((a,b) => a + " " + b);

Console.WriteLine(aggregate1);
//string aggregate2 = 
//string aggregate3 = 


//Sentence sentence2 = new Sentence("Delegates in C# .NET work like method references.");
//Console.WriteLine(sentence2.Aggregate((a, b) => a + "-" + b));

//Sentence sentence3 = new Sentence("Delegates in C# .NET work like method references.");

//Console.WriteLine(sentence3);

