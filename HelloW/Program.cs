using HelloW;

Greeter greeter = new Greeter();
greeter.text = "Hi";
Console.WriteLine(greeter.Greet("Carl"));
Console.WriteLine(greeter.Greet("Peter"));
greeter.text = "Hello programmer";
Console.WriteLine(greeter.Greet("Richard"));
Console.ReadKey();
