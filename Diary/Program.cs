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
    switch (choice)
    {
        case '1':
            diary.AddEntry();
            break;
        case '2':
            diary.SearchEntries();
            break;
        case '3':
            diary.DeleteEntries();
            break;
        case '4':
            Console.WriteLine("Press any key to quit the programm...");
            break;
        default:
            Console.WriteLine("Error. Press any key to choose another action.");
            break;
    }
    Console.ReadKey();
}
