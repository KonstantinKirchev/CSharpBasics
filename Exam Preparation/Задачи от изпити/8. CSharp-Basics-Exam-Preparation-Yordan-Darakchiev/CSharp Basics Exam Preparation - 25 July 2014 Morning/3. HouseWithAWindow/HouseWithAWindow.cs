﻿using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int houseWidth = 2 * n - 1;
        PrintRoof(n);
        Console.WriteLine("{0}", new string('*', houseWidth));
        PrintHouseBase(n, houseWidth);
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*",
                new string('.', n / 2),
                new string('*', n - 3));
        }
        PrintHouseBase(n, houseWidth);
        Console.WriteLine("{0}", new string('*', houseWidth));
    }

    static void PrintHouseBase(int n, int houseWidth)
    {
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', houseWidth - 2));
        }
    }

    static void PrintRoof(int n)
    {
        Console.WriteLine("{0}*{0}", new string('.', n - 1));

        int outerPoints = n - 2;
        int innerPoints = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerPoints),
                new string('.', innerPoints));
            outerPoints--;
            innerPoints += 2;
        }
    }
}