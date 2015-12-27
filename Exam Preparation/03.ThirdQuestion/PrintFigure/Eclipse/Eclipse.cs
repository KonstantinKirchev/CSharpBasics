using System;

class Eclipse
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string(' ', 1)
                        + new string('*', number * 2 - 2)
                        + new string(' ', number + 1)
                        + new string('*', number * 2 - 2)
                        + new string(' ', 1));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('/', number * 2 - 2)
                            + new string('*', 1)
                            + new string(' ', number - 1)
                            + new string('*', 1)
                            + new string('/', number * 2 - 2)
                            + new string('*', 1));
        }
        Console.WriteLine(new string('*', 1)
                        + new string('/', number * 2 - 2)
                        + new string('*', 1)
                        + new string('-', number - 1)
                        + new string('*', 1)
                        + new string('/', number * 2 - 2)
                        + new string('*', 1));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('/', number * 2 - 2)
                            + new string('*', 1)
                            + new string(' ', number - 1)
                            + new string('*', 1)
                            + new string('/', number * 2 - 2)
                            + new string('*', 1));
        }
        Console.WriteLine(new string(' ', 1)
                         + new string('*', number * 2 - 2)
                         + new string(' ', number + 1)
                         + new string('*', number * 2 - 2)
                         + new string(' ', 1));
    }
}


