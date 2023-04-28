using HumanRun;

Human charles = new Human("Charles New", 25);
Console.WriteLine(charles);
charles.Run(10);
charles.Run(10);
charles.Sleep(1);
charles.Run(10);

CSharpProgrammer karlis = new CSharpProgrammer("Karlis", 33, "Visual Studio");
Console.WriteLine(karlis);
karlis.Program(200);
karlis.Run(10);
karlis.Sleep(1);
karlis.Program(5000);
