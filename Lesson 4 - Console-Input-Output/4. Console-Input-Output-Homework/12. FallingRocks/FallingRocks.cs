using System;
using System.Collections.Generic;
using System.Threading;


class GameObject
{
    public int x;
    public int y;
    public char shape;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintObject(int col, int row, char charToPrint, 
        ConsoleColor fcolor = ConsoleColor.DarkGray, ConsoleColor bcolor = ConsoleColor.Black)
    {
        Console.SetCursorPosition(col, row);
        Console.BackgroundColor = bcolor;
        Console.ForegroundColor = fcolor;
        Console.Write(charToPrint);
    }

    static void PrintObject(int col, int row, string stringToPrint,
        ConsoleColor fcolor = ConsoleColor.DarkGray, ConsoleColor bcolor = ConsoleColor.Black)
    {
        Console.SetCursorPosition(col, row);
        Console.BackgroundColor = bcolor;
        Console.ForegroundColor = fcolor;
        Console.Write(stringToPrint);
    }

    static void Main()
    {
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight = 16;
        Console.BufferWidth = Console.WindowWidth = 32;

        Random dice = new Random();
        int sleepTime = 150;
        uint score = 0;
        sbyte lives = 3;
        char[] shapes = {'\u0023', '\u0025', '\u0026', '\u0040', '\u00A9'};
        int speedStep = 2000;

        GameObject midget = new GameObject();
        midget.x = 10;
        midget.y = Console.WindowHeight - 1;
        midget.shape = '☻';
        midget.color = ConsoleColor.Yellow;

        List<GameObject> rocks = new List<GameObject>();

        PrintObject(1, 1, "The aim of the game is to");
        PrintObject(1, 2, "avoid the incoming rocks.");
        PrintObject(1, 4, "Use the arrow keys to move.");
        PrintObject(1, 6, "Pick ♥ for lives,");
        PrintObject(1, 7, "and $ for points.");
        PrintObject(1, 9, "Press any key to start game.");
        Console.ReadKey();
        Console.Clear();

        for (int i = 0; i <= Console.WindowWidth - 1; i++)
        {
            PrintObject(i,1, '_', ConsoleColor.White);
        }

        while (true)
        {
            bool hit = false;
            int chance = dice.Next(0, 100);

            {
                GameObject rock = new GameObject();
                rock.x = dice.Next(0, 31);
                rock.y = 2;


                if (chance < 1)
                {
                    rock.shape = '♥';
                    rock.color = ConsoleColor.Red;
                }
                else if (chance < 10)
                {
                    rock.shape = '$';
                    rock.color = ConsoleColor.Green;
                }
                else if (chance < 100)
                {
                    rock.shape = shapes[dice.Next(0, 4)];
                    rock.color = ConsoleColor.DarkGray;
                }
                rocks.Add(rock);
            }

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (userInput.Key == ConsoleKey.LeftArrow && midget.x > 0)
                {
                    PrintObject(midget.x, midget.y, ' ', midget.color);
                    midget.x = midget.x - 1;
                }
                if (userInput.Key == ConsoleKey.LeftArrow && midget.x == 0)
                {
                    PrintObject(midget.x, midget.y, ' ', midget.color);
                    midget.x = Console.WindowWidth - 1;
                }
                if (userInput.Key == ConsoleKey.RightArrow && midget.x < Console.WindowWidth - 1)
                {
                    PrintObject(midget.x, midget.y, ' ', midget.color);
                    midget.x = midget.x + 1;
                }
                if (userInput.Key == ConsoleKey.RightArrow && midget.x == Console.WindowWidth - 1)
                {
                    PrintObject(midget.x, midget.y, ' ', midget.color);
                    midget.x = 0;
                }
                if (userInput.Key == ConsoleKey.DownArrow && midget.y < Console.WindowHeight - 1)
                {
                    PrintObject(midget.x, midget.y, ' ', midget.color);
                    midget.y = midget.y + 1;
                }
                if (userInput.Key == ConsoleKey.UpArrow && midget.y > 3)
                {
                    PrintObject(midget.x, midget.y, ' ', midget.color);
                    midget.y = midget.y - 1;
                }
            }
            PrintObject(midget.x, midget.y, midget.shape, midget.color);

            List<GameObject> newList = new List<GameObject>();
            for (int i = 0; i < rocks.Count; i++)
            {
                GameObject oldRock = rocks[i];
                GameObject newRock = new GameObject();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.shape = oldRock.shape;
                newRock.color = oldRock.color;

                                
                if (newRock.x == midget.x && newRock.y == midget.y && newRock.shape == '$')
                {
                    score += 500;
                    newRock.shape = ' ';
                }
                else if (newRock.x == midget.x && newRock.y == midget.y && newRock.shape == '♥')
                {
                    lives += 1;
                    newRock.shape = ' ';
                } 
                else if (newRock.x == midget.x && newRock.y == midget.y)
                {
                    hit = true;
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }

            foreach (GameObject rock in rocks)
            {
                PrintObject(rock.x, rock.y, ' ', ConsoleColor.Black);
            }
            rocks = newList;

            foreach (GameObject rock in rocks)
            {
                PrintObject(rock.x, rock.y, rock.shape, rock.color);
            }

            if (hit == true)
            {
                if (lives < 1)
                {
                    PrintObject(0, 0, "GAME OVER!", ConsoleColor.Red);
                    if (hit == true)
                    {
                        PrintObject(midget.x, midget.y, 'X', ConsoleColor.Red);
                    }
                    Console.ReadLine();
                    return;
                }
                if (hit == true)
                {
                    PrintObject(midget.x, midget.y, 'X', ConsoleColor.Red);
                }

                PrintObject(0,0, "Press enter", ConsoleColor.Red);
                Console.ReadLine();
                foreach (GameObject rock in rocks)
                {
                    PrintObject(rock.x, rock.y, ' ', ConsoleColor.Black);
                }
                rocks.Clear();
                newList.Clear();
                lives--;
                sleepTime += 20;
            }

            foreach (GameObject rock in rocks)
            {
                PrintObject(rock.x, rock.y, ' ', ConsoleColor.Black);
            }
            rocks = newList;

            foreach (GameObject rock in rocks)
            {
                PrintObject(rock.x, rock.y, rock.shape, rock.color);
            }
            PrintObject(3, 0, "Score: " + (int)score, ConsoleColor.Cyan);
            PrintObject(22, 0, "Lives: " + lives, ConsoleColor.Yellow);

            
            score += 10;
            if (score > speedStep)
            {
                speedStep = 2 * speedStep;
                sleepTime -= 5;
            }
            Thread.Sleep((int)sleepTime);
        }
    }
}
        

