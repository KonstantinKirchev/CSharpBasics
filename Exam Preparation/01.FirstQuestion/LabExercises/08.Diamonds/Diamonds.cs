using System;

class Diamonds
{
    static void Main()
    {
        sbyte n = sbyte.Parse(Console.ReadLine());
        if (n > 2 && n < 60)
        {
            if (n % 2 != 0)
            {

                    Console.WriteLine(new string('-', n / 2)
                                    + new string('*', 1)
                                    + new string('-', n / 2));
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - i)
                                    + new string('*', 1)
                                    + new string('-', 1 + 2 * i)
                                    + new string('*', 1)
                                    + new string('-', n / 2 - 1 - i));
                }
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine(new string('-', 1 + i)
                                    + new string('*', 1)
                                    + new string('-', n - 4 - 2 * i)
                                    + new string('*', 1)
                                    + new string('-', 1 + i));
                }
                    Console.WriteLine(new string('-', n / 2)
                                    + new string('*', 1)
                                    + new string('-', n / 2));
            }
        }
        Main();
    }
}

