using System;

class House
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string top = new string('.', input / 2) + new string('*', 1) + new string('.', input / 2);
        string sealing = new string('*', input);

        Console.WriteLine(top);
        for (int i = 1, j = 1; i < input / 2; i++, j += 2)
        {
            Console.WriteLine(new string('.', (input / 2) - i) + new string('*', 1) + new string('.', j) + new string('*', 1) + new string('.', (input / 2) - i)); 
        }
        Console.WriteLine(sealing);
        for (int i = 0; i < (input / 2) - 1; i++)
        {
            Console.WriteLine(new string('.', input / 4) + new string('*', 1) + new string('.', input - (2 * (input / 4)) - 2 ) + new string('*', 1) + new string('.', input / 4)); 
        }
        Console.WriteLine(new string('.', input / 4) + new string('*', 1) + new string('*', input - (2 * (input / 4)) - 2) + new string('*', 1) + new string('.', input / 4)); 
    }
}