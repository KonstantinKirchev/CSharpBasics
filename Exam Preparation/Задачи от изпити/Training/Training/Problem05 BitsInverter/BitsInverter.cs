using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class BitsInverter
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
        foreach (uint digit in temp)
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

    public static int[] GetPositions(int numbersCount, int step)
    {
        int maxPositions = numbersCount * 8;
        List<int> temp = new List<int>();
        for (int i = 0; i < maxPositions; i++)
        {
            if (i % step + 1 == 1)
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

        string binaryString = String.Empty;
        for (int i = 0; i < numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string temp = String.Empty;
            for (int j = 0; j < 8; j++)
            {
                int digit = (number >> j) & 1;
                temp += digit;
            }
            char[] tempArray = temp.Reverse().ToArray();
            foreach (char digit in tempArray)
            {
                binaryString += digit;
            }
        }

        StringBuilder builder = new StringBuilder(binaryString);
        int[] positions = GetPositions(numbersCount, step);
        for (int i = 0; i < positions.Length; i++)
        {
            if (builder[positions[i]] == '1')
            {
                builder.Replace('1', '0', positions[i], 1);
            }
            else
            {
                builder.Replace('0', '1', positions[i], 1);
            }
        }

        if (builder.Length < numbersCount * 8)
        {
            builder.Insert(0, "0", 1);
        }

        string resultAsString = builder.ToString();

        string currentString = String.Empty;
        for (int i = 0; i < resultAsString.Length; i++)
        {

            currentString += Convert.ToString(resultAsString[i]);
            if (currentString.Length == 8)
            {
                Console.WriteLine(Convert.ToInt32(currentString, 2));
                currentString = String.Empty;
            }

        }
        
    }
}