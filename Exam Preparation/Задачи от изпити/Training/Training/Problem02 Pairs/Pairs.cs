using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;
using System.Linq;

class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(' ').Select(digit => Convert.ToInt32(digit)).ToArray();
        double pairsSum = 0;
        int[] pairs = new int[numbers.Length / 2];
        for (int i = 0, j = 0; i < numbers.Length; i++, j++)
        {
            pairs[j] = numbers[i] + numbers[i + 1];
            pairsSum += pairs[j];
            i++;
        }

        int[] top = new int[pairs.Length / 2];
        int[] bottom = new int[pairs.Length - pairs.Length / 2];
        Array.Copy(pairs, top, top.Length);
        Array.Copy(pairs, top.Length, bottom, 0, bottom.Length);

        bool areEqual = false;
        for (int i = 0; i < top.Length; i++)
        {
            if (top[i] == bottom[i])
            {
                areEqual = true;
            }
            else
            {
                areEqual = false;
            }
        }

        if (numbers.Length == 2)
        {
            if (numbers[0] == numbers[1])
            {
                Console.WriteLine("Yes, value={0}", pairs[0]);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", Math.Max(numbers[0], numbers[1]) - Math.Min(numbers[0], numbers[1]));
            }
        }
        else
        {
            if (areEqual == true)
            {
                Console.WriteLine("Yes, value={0}", pairs[0]);
            }
            else
            {
                int diff = 0, maxDiff = 0;
                for (int i = 0; i < pairs.Length; i++)
                {
                    if (i < pairs.Length - 1)
                    {
                        diff = Math.Max(pairs[i], pairs[i + 1]) - Math.Min(pairs[i], pairs[i + 1]);
                        if (maxDiff < diff)
                        {
                            maxDiff = diff;
                        }
                    }

                }
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}