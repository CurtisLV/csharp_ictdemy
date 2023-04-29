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

    public Snake()
    {
        IsAlive = true;
        Direction = 0;
        parts.Add(new Block(15, 7, color));
        parts.Add(new Block(14, 7, color));
        parts.Add(new Block(15, 8, color));
        PlaceFood();
    }

    public void Draw()
    {
        foreach (Block part in parts)
        {
            part.Draw();
        }
        food.Draw();
    }

    public void Move()
    {
        if (IsAlive)
        {
            Block newHead = new Block(parts[0].X, parts[0].Y, 0);
            if (Direction == 0)
            {
                newHead.X++;
            }
            if (Direction == 90)
            {
                newHead.Y--;
            }
            if (Direction == 180)
            {
                newHead.X--;
            }
            if (Direction == 270)
            {
                newHead.Y++;
            }
            parts.Insert(0, newHead);

            if (parts[0].Collision(food))
            {
                PlaceFood();
            }
            else
            {
                parts.RemoveAt(parts.Count - 1);
            }

            if (parts[0].OutOfConsole)
            {
                IsAlive = false;
            }

            for (int i = 1; i < parts.Count; i++)
            {
                if (parts[0].Collision(parts[i]))
                {
                    IsAlive = false;
                }
            }
        }
    }

    public void PlaceFood()
    {
        Console.Beep(900, 50);
        bool isCollision = true;

        while (isCollision)
        {
            food.X = random.Next(Console.WindowWidth / 2);
            food.Y = random.Next(Console.WindowHeight);
            isCollision = false;
            foreach (Block part in parts)
            {
                if (food.Collision(part))
                {
                    isCollision = true;
                }
            }
        }
    }
}
