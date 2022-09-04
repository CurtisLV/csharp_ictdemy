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
}
