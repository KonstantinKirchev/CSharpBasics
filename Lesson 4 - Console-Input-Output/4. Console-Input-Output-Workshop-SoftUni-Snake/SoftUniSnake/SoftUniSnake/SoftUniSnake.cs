using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class SoftUniSnake
{
    static void Main()
    {
        Random randomGenerator = new Random();

        // Console settings
        double sleepTime = 200;
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;

        Point[] points = 
        {
            new Point(0, -1), // up
            new Point(1, 0), // right
            new Point(0, 1), // down
            new Point(-1, 0) // left
        };

        int direction = 1;
        int snakeLength = 6;

        Point food = new Point(randomGenerator.Next(0, Console.WindowWidth),
            randomGenerator.Next(0, Console.WindowHeight));

        Queue<Point> snake = new Queue<Point>();
        for (int i = 2; i < snakeLength + 2; i++)
        {
            snake.Enqueue(new Point(i, 0));
        }

        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < snakeLength; i++)
        {
            Point currentPoint = snake.ElementAt(i);
            Console.SetCursorPosition(currentPoint.X, currentPoint.Y);
            Console.Write("*");
        }

        Point snakeHead = snake.Last();
        Console.SetCursorPosition(snakeHead.X, snakeHead.Y);
        Console.Write("@");
        Console.SetCursorPosition(food.X, food.Y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("#");

        while (true)
        {
            // Read user input
            #region User input
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow)
                {
                    if (direction != 2)
                    {
                        direction = 0;
                    }
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (direction != 3)
                    {
                        direction = 1;
                    }
                }
                if (key == ConsoleKey.DownArrow)
                {
                    if (direction != 0)
                    {
                        direction = 2;
                    }
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    if (direction != 1)
                    {
                        direction = 3;
                    }
                }
            }
            #endregion

            Point tail = snake.Dequeue();
            Console.SetCursorPosition(tail.X, tail.Y);
            Console.Write(" ");
            Point currentHead = snake.Last();
            snakeHead = new Point(
                currentHead.X + points[direction].X,
                currentHead.Y + points[direction].Y);
            snake.Enqueue(snakeHead);
            if (snakeHead.X == food.X && snakeHead.Y == food.Y)
            {
                Console.SetCursorPosition(food.X, food.Y);
                Console.Write(" ");
                food = new Point(randomGenerator.Next(0, Console.WindowWidth),
            randomGenerator.Next(0, Console.WindowHeight));
                sleepTime -= 0.5;
                if (sleepTime < 50)
                {
                    sleepTime = 50;
                }

                snakeHead = new Point(
                snakeHead.X + points[direction].X,
                snakeHead.Y + points[direction].Y);
                snake.Enqueue(snakeHead);
            }

            #region Print snake
            for (int i = 0; i < snakeLength; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Point currentPoint = snake.ElementAt(i);
                if (currentPoint.X < 0 || currentPoint.X >= Console.WindowWidth ||
                currentPoint.Y < 0 || currentPoint.Y >= Console.WindowHeight)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You just died!");
                    return;
                }
                Console.SetCursorPosition(currentPoint.X, currentPoint.Y);
                Console.Write("*");
            }

            snakeHead = snake.Last();

            Console.SetCursorPosition(snakeHead.X, snakeHead.Y);
            Console.Write("@");
            Console.SetCursorPosition(food.X, food.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("#");
            #endregion

            Thread.Sleep((int)sleepTime);
        }
    }
}