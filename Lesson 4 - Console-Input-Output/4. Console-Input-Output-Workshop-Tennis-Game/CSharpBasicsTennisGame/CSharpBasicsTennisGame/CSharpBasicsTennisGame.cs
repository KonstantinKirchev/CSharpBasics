using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasicsTennisGame
{
    class CSharpBasicsTennisGame
    {
        public static void Main()
        {
            const int PLAYGROUNG_HEIGHT = 20;
            const int PAD_HEIGHT = 5;
            const char BALL_CHAR = '*';

            int playerPositionY = 8;
            int ballX, ballY;
            int ballDirection; 
            Random randomGenerator = new Random();
            ballX = randomGenerator.Next(15, 65);
            ballY = randomGenerator.Next(3, 17);
            ballDirection = randomGenerator.Next(1, 4);

            Console.WriteLine(ballDirection);
            Console.CursorVisible = false;
            Console.WindowHeight = PLAYGROUNG_HEIGHT;
            Console.BufferHeight = Console.WindowHeight;

            for (int i = 0; i < PAD_HEIGHT; i++)
            {
                Console.SetCursorPosition(0, playerPositionY + i);
                Console.Write('|');
            }
            Console.SetCursorPosition(ballX, ballY);
            Console.Write(BALL_CHAR);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        playerPositionY-=2;
                        if (playerPositionY < 0)
                        {
                            playerPositionY = 0;
                        }
                    }

                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        playerPositionY+=2;
                        if (playerPositionY > PLAYGROUNG_HEIGHT - PAD_HEIGHT)
                        {
                            playerPositionY = PLAYGROUNG_HEIGHT - PAD_HEIGHT;
                        }
                    }
                }
                
                switch (ballDirection)
                {
                    case 1:
                        ballX--;
                        ballY--;
                        break;
                    case 2:
                        ballX++;
                        ballY--;
                        break;
                    case 3:
                        ballX++;
                        ballY++;
                        break;
                    case 4:
                        ballX--;
                        ballY++;
                        break;
                }
                if (ballX == 0)
                {
                    if ((ballY >= playerPositionY) && (ballY <= playerPositionY + 4))
                    {
                        if (ballDirection == 1)
                        {
                            ballDirection = 2;
                        }
                        else if (ballDirection == 4)
                        {
                            ballDirection = 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("GAME OVER, DUDE");
                        return;
                    }
               
                }
                if (ballX == 79)
                {
                    if (ballDirection == 2)
                    {
                        ballDirection = 1;
                    }
                    else if (ballDirection == 3)
                    {
                        ballDirection = 4;
                    }
                }
                if (ballY == 0)
                {
                    if (ballDirection == 2)
                    {
                        ballDirection = 3;
                    }
                    else if (ballDirection == 1)
                    {
                        ballDirection = 4;
                    }
                }
                if (ballY == PLAYGROUNG_HEIGHT-1)
                {
                    if (ballDirection == 3)
                    {
                        ballDirection = 2;
                    }
                    else if (ballDirection == 4)
                    {
                        ballDirection = 1;
                    }
                }


                Console.Clear();
                for (int i = 0; i < PAD_HEIGHT; i++)
                {
                    Console.SetCursorPosition(0, playerPositionY + i);
                    Console.Write('|');
                }
                Console.SetCursorPosition(ballX, ballY);
                Console.Write(BALL_CHAR);

                Thread.Sleep(50);
            }
        }
    }
}
