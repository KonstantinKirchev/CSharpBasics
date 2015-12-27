using System;

class WineGlass
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('\\', 1)
                        + new string('*', n - 2)
                        + new string('/', 1));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine(new string('.', 1 + i)
                            + new string('\\', 1)
                            + new string('*', (n - 4) - (2 * i))
                            + new string('/', 1)
                            + new string('.', 1 + i));
        }
        Console.WriteLine(new string('.', (n / 2) - 1)
                        + new string('\\', 1)
                        + new string('/', 1)
                        + new string('.', (n / 2) - 1));
        if (n < 12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('.', n / 2 - 1)
                                + new string('|', 1)
                                + new string('|', 1)
                                + new string('.', n / 2 - 1));
            }
        }
        else
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine(new string('.', n / 2 - 1)
                                + new string('|', 1)
                                + new string('|', 1)
                                + new string('.', n / 2 - 1));
            }
        }

        if (n >= 12)
        {
            Console.WriteLine(new string('-', n));
            Console.WriteLine(new string('-', n));

        }
        else
        {
            Console.WriteLine(new string('-', n));
        }
    }
}

