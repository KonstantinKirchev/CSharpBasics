using System;

class FirTree
{

    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string bottom = new string('.', input - 2) + new string('*', 1) + new string('.', input - 2);
        int astrixCount = 1 + 2;

        Console.WriteLine(bottom);
        for (int i = 1; i < input - 1; i++)
        {
            Console.WriteLine(new string('.', input - 2 - i) + new string('*', astrixCount) + new string('.', input - 2 - i));
            astrixCount += 2;
        }
        Console.WriteLine(bottom);

    }
}