using Diary;

DiaryC diary = new DiaryC();
char choice = '0';

// main loop 

while (choice != '4') 
{
    diary.PrintHomeScreen();
    Console.WriteLine();
    Console.WriteLine("Choose an action:");
    Console.WriteLine("1 - Add an entry");
    Console.WriteLine("2 - Search for entries");
    Console.WriteLine("3 - Delete entries");
    Console.WriteLine("4 - End");
    choice = Console.ReadKey().KeyChar;
    Console.WriteLine();
    // reaction to the choice
}
