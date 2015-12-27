using System;
using System.Linq;
using System.Numerics;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        Array.Sort(numbers);
        Array.Reverse(numbers);
        BigInteger biggestNumber = numbers[0];
        BigInteger sum = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        if (biggestNumber == sum)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            if (biggestNumber > sum)
            {
                Console.WriteLine("No, diff={0}", biggestNumber - sum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", sum - biggestNumber);
            }
        }
    }
}