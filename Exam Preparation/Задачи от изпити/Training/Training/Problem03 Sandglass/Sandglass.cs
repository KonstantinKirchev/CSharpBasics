using System;
using System.Collections.Generic;

class Sandglass
{

    static void Main()
    {

        int input = int.Parse(Console.ReadLine());

        char dot = '.';
        char asterisk = '*';
        string frame = new string(asterisk, input);

        List<int> asteriskCountList = new List<int>();
        for (int i = 0; i < input; i++)
        {
            if (i % 2 == 1)
            {
                asteriskCountList.Add(i);
            }
        }
        asteriskCountList.Reverse();
        int[] asteriskCount = asteriskCountList.ToArray();

        Console.WriteLine(frame);
        for (int i = 0; i < asteriskCount.Length; i++)
        {
            Console.WriteLine(new string(dot, i + 1) + new string(asterisk, asteriskCount[i]) + new string(dot, i + 1));
        }

        for (int i = asteriskCount.Length; i > 1; i--)
        {
            Console.WriteLine(new string(dot, i - 1) + new string(asterisk, asteriskCount[i - 2]) + new string(dot, i - 1));
        }
        Console.WriteLine(frame);
    }
}