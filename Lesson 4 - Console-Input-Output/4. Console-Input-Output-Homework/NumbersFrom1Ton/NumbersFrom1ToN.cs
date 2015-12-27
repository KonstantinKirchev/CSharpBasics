using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                Console.WriteLine(i);
            }
            Main();
        }
    }

