using SnakeGame;

Snake snake = new Snake(); // The snake instance
while (snake.IsAlive) // The game loop
{
    Console.BackgroundColor = ConsoleColor.Green; // Green background
    Console.Clear(); // Clear the console
    snake.Draw(); // Draw the snake
    snake.Move(); // Move the snake
    Thread.Sleep(50); // Wait 50 ms
    // If any key is pressed
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey(); // Get the key
        // Reaction to each key
        if (key.Key == ConsoleKey.RightArrow)
            snake.Direction = 0;
        if (key.Key == ConsoleKey.LeftArrow)
            snake.Direction = 180;
        if (key.Key == ConsoleKey.DownArrow)
            snake.Direction = 270;
        if (key.Key == ConsoleKey.UpArrow)
            snake.Direction = 90;
    }
}
