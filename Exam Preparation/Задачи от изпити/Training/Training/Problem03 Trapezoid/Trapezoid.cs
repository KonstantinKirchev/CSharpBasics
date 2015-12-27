using System;

class Trapezoid
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.Write(new string('.', input));
        Console.Write(new string('*', input));
        Console.WriteLine();
        for (int i = input ; i > 1; i--)
        {
            Console.Write(new string('.', i-1));
            Console.Write('*');
            Console.Write(new string('.',  (((input*2) - i))-1));
            Console.Write('*');
            Console.WriteLine();
        }
        Console.Write(new string('*', input+input));
        Console.WriteLine();
    }
}
