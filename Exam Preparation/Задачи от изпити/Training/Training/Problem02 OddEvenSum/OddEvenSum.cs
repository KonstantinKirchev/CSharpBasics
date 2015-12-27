using System;

class OddEvenSum
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] numbers = new int[input * 2];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int evenSum = 0, oddSum = 0;
        for (int i = 0, j = 1; i < numbers.Length; i += 2, j += 2)
        {
            evenSum += numbers[i];
            oddSum += numbers[j];
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum={0}", evenSum);
        }
        else
        {
            if (evenSum > oddSum)
            {
                Console.WriteLine("No, diff={0}", evenSum - oddSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", oddSum - evenSum);
            }
        }
    }
}