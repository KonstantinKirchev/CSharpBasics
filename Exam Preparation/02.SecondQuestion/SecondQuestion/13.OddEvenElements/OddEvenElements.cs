using System;
using System.Linq;

class OddEvenElements
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        decimal sumEven = 0;
        decimal sumOdd = 0;
        decimal minEven = decimal.MaxValue;
        decimal maxEven = decimal.MinValue;
        decimal minOdd = decimal.MaxValue;
        decimal maxOdd = decimal.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            decimal tempElement = decimal.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                sumOdd += tempElement;
                maxOdd = Math.Max(maxOdd, tempElement);
                minOdd = Math.Min(minOdd, tempElement);
            }
            else
            {
                sumEven += tempElement;
                maxEven = Math.Max(maxEven, tempElement);
                minEven = Math.Min(minEven, tempElement);
            }
        }
        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)sumOdd, (double)minOdd, (double)maxOdd);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)sumOdd, (double)minOdd, (double)maxOdd, (double)sumEven, (double)minEven, (double)maxEven);
        }
    }
}

