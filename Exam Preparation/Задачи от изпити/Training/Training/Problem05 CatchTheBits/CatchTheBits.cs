using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static string ConvertDecimalToBinary(int number)
    {
        List<int> temp = new List<int>();
        for (int i = 0; i < 8; i++)
        {
            temp.Add(number & 1);
            number = number >> 1;
        }
        temp.Reverse();

        StringBuilder builder = new StringBuilder();
        foreach (int digit in temp)
        {
            builder.Append(digit);
        }

        string result = builder.ToString();
        return result;
    }
    public static int ConvertBinaryToDecimal(string input)
    {


        UInt64 number = Convert.ToUInt64(input, 2);
        int result = Convert.ToInt32(number);
        return result;
    }
    private static int[] GetPositions(int numbersCount, int step)
    {
        int maxPositions = numbersCount * 8;
        List<int> temp = new List<int>();
        for (int i = 0; i < maxPositions; i++)
        {
            if (i % step == 1)
            {
                temp.Add(i);
            }
        }
        int[] positions = temp.ToArray();
        return positions;
    }
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        string numbersInBinary = string.Empty;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbersInBinary += ConvertDecimalToBinary(numbers[i]);
        }
        int[] positions = GetPositions(numbersCount, step);

        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < numbersInBinary.Length; i++)
        {
            for (int j = 0; j < positions.Length; j++)
            {
                if (i == positions[j])
                {
                    builder.Append(numbersInBinary[i]);
                }
            }
        }
        while (builder.Length % 8 != 0)
        {
            builder.Append('0');
        }

        string binaryString = builder.ToString();

        var res = String.Join(",", Regex.Matches(binaryString, @"\d{8}").Cast<Match>());

        string[] resultsInBinary = res.Split(',');
        int[] results = new int[resultsInBinary.Length];
        for (int i = 0; i < resultsInBinary.Length; i++)
        {
            results[i] = Convert.ToInt32(resultsInBinary[i], 2);
        }
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine(results[i]);
        }
    }
}