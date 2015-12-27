using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class BitKiller
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
        builder.Clear();
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

        StringBuilder builder = new StringBuilder(numbersInBinary);
        for (int i = 0; i < positions.Length; i++)
        {
            builder.Replace("0", "9", positions[i], 1);
            builder.Replace("1", "9", positions[i], 1);

        }
        string tempString = builder.ToString();
        builder.Clear();

        string result = string.Empty;
        string regexPattern = "[0 1]";
        MatchCollection matches = Regex.Matches(tempString, regexPattern);
        builder.Clear();
        foreach (var item in matches)
        {
            builder.Append(item);
        }
        while (builder.Length % 8 != 0)
        {
            builder.Append('0');
        }
        result = builder.ToString();
        builder.Clear();

        var res = String.Join(",", Regex.Matches(result, @"\d{8}").Cast<Match>());

        string[] resultsInBinary = res.Split(',');
        int[] results = new int[resultsInBinary.Length];
        for (int i = 0; i < resultsInBinary.Length; i++)
        {
            results[i] = Convert.ToInt32(resultsInBinary[i], 2);
        }

        if (step == 1)
        {
            if (numbers[0] == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(128);
            }
        }
        else
        {
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}