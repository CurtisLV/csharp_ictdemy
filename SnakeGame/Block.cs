using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;

internal class Block
{
    public int X { get; set; }
    public int Y { get; set; }
    public ConsoleColor Color { get; set; }

    public bool OutOfConsole { get {
            return (X >= Console.WindowWidth / 2 || Y >= Console.WindowHeight || X < 0 || Y < 0);
        }
    }

    public Block(int x, int y, ConsoleColor color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public void Draw()
    {
        if (!OutOfConsole)
        {
            Console.CursorLeft = X * 2; // To use up less horizontal space, we draw each block as 2 characters
            Console.CursorTop = Y;
            Console.ForegroundColor = Color;
            Console.Write("██");
        }
    }

    public bool Collision(Block block)
    {
        return (X == block.X && Y == block.Y);
    }

}
