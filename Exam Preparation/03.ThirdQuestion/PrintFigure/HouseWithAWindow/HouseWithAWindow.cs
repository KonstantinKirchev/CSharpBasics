using System;

class HouseWithAWindow
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', number - 1)
                        + new string('*', 1)
                        + new string('.', number - 1));
        for (int i = 0; i < number - 2; i++)
        {
            Console.WriteLine(new string('.', (number - 2) - i)
                            + new string('*', 1)
                            + new string('.', 1 + 2 * i)
                            + new string('*', 1)
                            + new string('.', (number - 2) - i));
        }
        Console.WriteLine(new string('*', 1)
                        + new string('.', number * 2 - 3)
                        + new string('*', 1));
        Console.WriteLine(new string('*', number * 2 - 1));
        for (int i = 0; i < number / 4; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('.', number * 2 - 3)
                            + new string('*', 1));
        }
        for (int i = 0; i < number / 2; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('.', number / 2)
                            + new string('*', number - 3)
                            + new string('.', number / 2)
                            + new string('*', 1));
        }
        for (int i = 0; i < number / 4; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('.', number * 2 - 3)
                            + new string('*', 1));
        }
        Console.WriteLine(new string('*', number * 2 - 1));
    }
}


