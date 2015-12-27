using System;

class ForestRoad
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', (number - 1) - i));
            Console.WriteLine();
        }
        
        for (int i = number-2; i >= 0; i--)
        {
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', (number - 1) - i));
            Console.WriteLine();
        }

    }
}

