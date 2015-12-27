using System;

class Arrow
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', number / 2)
                         + new string('#', number)
                         + new string('.', number / 2));
        for (int i = 0; i < number - 2; i++)
        {
            Console.WriteLine(new string('.', number / 2)
                            + new string('#', 1)
                            + new string('.', number - 2)
                            + new string('#', 1)
                            + new string('.', number / 2));
        }
        Console.WriteLine(new string('#', number / 2 + 1)
                        + new string('.', number - 2)
                        + new string('#', number / 2 + 1));
        for (int i = 0; i < number - 2; i++)
        {
            Console.WriteLine(new string('.', 1 + i)
                            + new string('#', 1)
                            + new string('.', number * 2 - 5 - i * 2)
                            + new string('#', 1)
                            + new string('.', 1 + i));
        }
        Console.WriteLine(new string('.', number - 1)
                        + new string('#', 1)
                        + new string('.', number - 1));
    }
}


