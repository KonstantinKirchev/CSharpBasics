using System;
using System.Numerics;
using System.Collections.Generic;

class Tribonacci
{


    static void Main()
    {
        long numberOne = long.Parse(Console.ReadLine());
        long numberTwo = long.Parse(Console.ReadLine());
        long numberThree = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int numbersToDisplay = n;
        for (int i = 1; i < n; i++)
        {
            numbersToDisplay += i;
        }

        long result = 0;

        List<long> list = new List<long>();
        list.Add(numberOne);
        list.Add(numberTwo);
        list.Add(numberThree);
        for (int i = 4; i <= numbersToDisplay; i++)
        {
            result = numberOne + numberTwo + numberThree;
            numberOne = numberTwo;
            numberTwo = numberThree;
            numberThree = result;
            list.Add(result);
        }

        int s = 0;
        for (int p = 1; p <= n; p++) // for 5 loops
        {
            if (s >= list.Count)
            {
                break;
            }
            for (int j = 1; j <= p; j++) // to display values
            {
                Console.Write(list[s] + " ");
                s++;
            }
            Console.WriteLine();// for line break
        }

    }
}
