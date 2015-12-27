using System;
using System.Collections.Generic;
using System.Text;

class DancingBits
{
    static void Main()
    {

        int target = int.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }


        string results = string.Empty;
        for (int i = 0; i < numbers.Length; i++)
        {
            results += Convert.ToString(numbers[i], 2);
        }

        int lenghtOfSequence = 0;
        char previousBit = '8';
        int result = 0;

        for (int i = 0; i < results.Length; i++)
        {
            if (results[i] == previousBit)
            {
                lenghtOfSequence += 1;
            }
            else
            {
                if (lenghtOfSequence == target)
                {
                    result += 1;
                }
                lenghtOfSequence = 1;
            }
            previousBit = results[i];
        }
        if (lenghtOfSequence == target)
        {
            result += 1;
        }
        Console.WriteLine(result);
    }
}