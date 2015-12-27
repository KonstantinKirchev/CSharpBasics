using System;

    class ConsoleGraphics
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            if (n>2 && n<50)
            {
                if (n % 2 != 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(new string('*', n * 2));
                    }
                    for (int i = 0; i < n - 1; i++)
                    {
                        Console.WriteLine(new string('*', (n + 1) / 2)
                                        + new string(' ', n - 1)
                                        + new string('*', (n + 1) / 2));
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(new string('~', n * 2));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
            Main();
        }
    }

