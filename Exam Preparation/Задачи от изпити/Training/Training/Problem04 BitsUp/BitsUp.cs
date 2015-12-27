using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class BitsUp
{
    public static int ConvertBinaryToDecimal(string input)
    {
        int result = Convert.ToInt32(input, 2);
        return result;
    }

    public static string ConvertDecimalToBinary(int number)
    {
        List<int> temp = new List<int>();
        for (int i = 0; i < 8; i++)
        {
            temp.Add(number & 1);
            number = number >> 1;
        }
        temp.Reverse();

        StringBuilder builder = new StringBuilder();
        foreach (uint digit in temp)
        {
            builder.Append(digit);
        }
        string result = builder.ToString();
        return result;
    }

    public static int[] GetPositions(int numbersCount, int step)
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
        int[] positions = GetPositions(numbersCount, step);
        string binaryString = string.Empty;
        for (int i = 0; i < numbers.Length; i++)
        {
            binaryString += ConvertDecimalToBinary(int.Parse(Console.ReadLine()));
        }

        StringBuilder builder = new StringBuilder();
        for (int i = 0, j = 0; i < binaryString.Length; i++)
        {
            if (j != positions.Length && i == positions[j])
            {
                if (binaryString[i] == '0')
                {
                    builder.Append('1');
                }
                else
                {
                    builder.Append(binaryString[i]);
                }
                j++;
            }
            else
            {
                builder.Append(binaryString[i]);
            }
        }
        string modifiedBinaryString = builder.ToString();

        List<string> result = new List<string>(Regex.Split(modifiedBinaryString, @"(?<=\G.{8})", RegexOptions.Singleline)); // splits the string by 8 characters ( one 8 bit number )
        int[] answers = new int[numbersCount];
        for (int i = 0; i < numbersCount; i++)
        {
            answers[i] = ConvertBinaryToDecimal(result[i]);
        }

        for (int i = 0; i < numbersCount; i++)
        {
            Console.WriteLine(answers[i]);
        }
    }
}