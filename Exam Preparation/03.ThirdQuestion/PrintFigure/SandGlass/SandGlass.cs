using System;

class Program
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', number));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', 1 + i)
                            + new string('*', number - 2 - 2 * i)
                            + new string('.', 1 + i));
        }
        Console.WriteLine(new string('.', number / 2)
                        + new string('*', 1)
                        + new string('.', number / 2));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', number / 2 - 1 - i)
                            + new string('*', 3 + 2 * i)
                            + new string('.', number / 2 - 1 - i));
        }
        Console.WriteLine(new string('*', number));
    }

}


