using System;

class Plane
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', n / 2 + n)
                        + new string('*', 1)
                        + new string('.', n / 2 + n));
        for (int i = 0; i < n / 2 + 2; i++)
        {
            Console.WriteLine(new string('.', n / 2 + (n - 1) - i)
                            + new string('*', 1)
                            + new string('.', 1 + i * 2)
                            + new string('*', 1)
                            + new string('.', n / 2 + (n - 1) - i));
        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', n - 4 - i * 2)
                            + new string('*', 1)
                            + new string('.', n + 6 + i * 4)
                            + new string('*', 1)
                            + new string('.', n - 4 - i * 2));
        }
        Console.WriteLine(new string('*', 1)
                        + new string('.', n - 2)
                        + new string('*', 1)
                        + new string('.', n)
                        + new string('*', 1)
                        + new string('.', n - 2)
                        + new string('*', 1));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('.', n - 4 - i * 2)
                            + new string('*', 1)
                            + new string('.', 1 + i * 2)
                            + new string('*', 1)
                            + new string('.', n)
                            + new string('*', 1)
                            + new string('.', 1 + i * 2)
                            + new string('*', 1)
                            + new string('.', n - 4 - i * 2)
                            + new string('*', 1));
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', n - 1 - i)
                            + new string('*', 1)
                            + new string('.', n + i * 2)
                            + new string('*', 1)
                            + new string('.', n - 1 - i));
        }
        Console.WriteLine(new string('*', n * 3));
    }

}


