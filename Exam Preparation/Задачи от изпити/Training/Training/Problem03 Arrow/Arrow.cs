using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string top = new string('.', input / 2) + new string('#', input) + new string('.', input / 2);
        string body = new string('.', input / 2) + new string('#', 1) + new string('.', input - 2) + new string('#', 1) + new string('.', input / 2);
        string tipBase = new string('#', (input / 2) + 1) + new string('.', input - 2) + new string('#', (input / 2) + 1);
        string tipEnd = new string('.', input - 1) + new string('#', 1) + new string('.', input - 1);

        Console.WriteLine(top);
        for (int i = 0; i < input - 2; i++)
        {
            Console.WriteLine(body);
        }
        Console.WriteLine(tipBase);
        for (int i = 1, j = 2; i < input - 1; i++, j += 2)
        {
            Console.WriteLine(new string('.', i) + new string('#', 1) + new string('.', (tipBase.Length - 2) - j) + new string('#', 1) + (new string('.', i))); // tip body
        }
        Console.WriteLine(tipEnd);
    }
}