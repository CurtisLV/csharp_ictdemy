using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;

internal class Snake
{

    private List<Block> parts = new List<Block>();

    public int Direction { get; set; }
    public bool IsAlive { get; set; }

    private Block food = new Block(0, 0, ConsoleColor.Red);

    Random random = new Random();

    private ConsoleColor color = ConsoleColor.Magenta;
}
