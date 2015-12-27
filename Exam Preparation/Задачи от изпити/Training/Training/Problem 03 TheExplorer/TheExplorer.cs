using System;

class TheExplorer
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string top = new string('-', input / 2) + new string('*', 1) + new string('-', input / 2);
        string middle = new string('*', 1) + new string('-', input - 2) + new string('*', 1);
        string bottom = top;

        Console.WriteLine(top);
        for (int i = 1, j = 1; i < input / 2; i++, j += 2)
        {
            Console.WriteLine(new string('-', (input / 2) - i) + new string('*', 1) + new string('-', j) + new string('*', 1) + new string('-', (input / 2) - i));
        }
        Console.WriteLine(middle);
        for (int i = 1, j = 3; i < input / 2; i++, j += 2)
        {
            Console.WriteLine(new string('-', i) + new string('*', 1) + new string('-', (input - 1) - j) + new string('*', 1) + new string('-', i));
        }
        Console.WriteLine(bottom);
    }
}