using System;
using System.Collections.Generic;
using System.Text;

class WeAllLoveBits
{
    public static int ConvertBinaryToDecimal(string input)
    {

        UInt64 number = Convert.ToUInt64(input, 2);
        int result = Convert.ToInt32(number);
        return result;
    }

    public static string ConvertDecimalToBinaryReversed(int number)
    {
        List<int> temp = new List<int>();

        while (number > 0)
        {
            temp.Add(number & 1);
            number = number >> 1;
        }

        StringBuilder builder = new StringBuilder();
        foreach (uint digit in temp)
        {
            builder.Append(digit);
        }
        string result = builder.ToString();
        return result;
    }

    public static int InvertBitsInInt(int number)
    {
        int mask = number;
        mask |= mask >> 1;
        mask |= mask >> 2;
        mask |= mask >> 4;
        mask |= mask >> 8;
        mask |= mask >> 16;

        int invertedP = ~number & mask;
        return invertedP;
    }

    static void Main()
    {

        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];
        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            int invertedP = InvertBitsInInt(numbers[i]);
            string reversedTempString = ConvertDecimalToBinaryReversed(numbers[i]);
            int reversedP = ConvertBinaryToDecimal(reversedTempString);
            int result = (numbers[i] ^ invertedP) & reversedP;
            Console.WriteLine(result);
        }
    }
}