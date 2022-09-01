using TheLottery;

Lottery lottery = new Lottery();
Console.WriteLine("Welcome to our lottery program.");

char choice = '0';

while (choice != '3')
{
    Console.WriteLine("1 - Lot the next number");
    Console.WriteLine("2 - Print numbers");
    Console.WriteLine("3 - Quit");

    choice = Console.ReadKey().KeyChar;
    
    Console.WriteLine();

    // react to choice
    switch (choice)
    {
        case '1':
            Console.WriteLine($"You got a: {lottery.Lot()}");
            break;
        case '2':
            Console.WriteLine($"Numbers drawn: {lottery.Print()}");
            break;
        case '3':
            Console.WriteLine("Thanks for using our Lotto program");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again!");
            break;
    }
}
