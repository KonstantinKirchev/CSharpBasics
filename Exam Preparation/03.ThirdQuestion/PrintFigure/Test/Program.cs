using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', (n * 3) / 2)
                        + new string('*', 1)
                        + new string('.', (n * 3) / 2));
        for (int i = 0; i < (n / 2) + 2; i++)
        {
            Console.WriteLine(new string('.', ((n * 3) / 2) - 1 - i)
                            + new string('*', 1)
                            + new string('.', 1 + (2 * i))
                            + new string('*', 1)
                            + new string('.', ((n * 3) / 2) - 1 - i));
        }
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine(new string('.', (n - 4) - 2 * i)
                            + new string('*', 1)
                            + new string('.', n + 6 + (4 * i))
                            + new string('*', 1)
                            + new string('.', (n - 4) - 2 * i));
        }
        Console.WriteLine(new string('*', 1)
                        + new string('.', n - 2)
                        + new string('*', 1)
                        + new string('.', n)
                        + new string('*', 1)
                        + new string('.', n - 2)
                        + new string('*', 1));

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('.', (n-4) - (2*i))
                            + new string('*', 1)
                            + new string('.', 1 + (2 * i))
                            + new string('*', 1)
                            + new string('.', n)
                            + new string('*', 1)
                            + new string('.', 1 + (2 * i))
                            + new string('*', 1)
                            + new string('.', (n - 4) - (2 * i))
                            + new string('*', 1));
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', n - 1 - i)
                            + new string('*', 1)
                            + new string('.', n + (2 * i))
                            + new string('*', 1)
                            + new string('.', n - 1 - i));
        }
        Console.WriteLine(new string('*', n * 3));
        

    }
}



