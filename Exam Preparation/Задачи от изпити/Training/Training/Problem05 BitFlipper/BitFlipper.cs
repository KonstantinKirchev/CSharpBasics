using System;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class BitFlipper
{
    public static string ConvertDecimalToBinary(BigInteger number)
    {
        List<BigInteger> temp = new List<BigInteger>();
        for (int i = 0; i < 64; i++)
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
    public static BigInteger ConvertBinaryToDecimal(string resultAsString)
    {
        BigInteger number = BigInteger.Parse(resultAsString);
        BigInteger result = 0;
        BigInteger lastDigit = 0;
        int length = resultAsString.Length;
        for (int i = 0; i < length; i++)
        {
            lastDigit = number % 10;
            result += lastDigit * (BigInteger)(Math.Pow(2, i));
            number = number / 10;
        }
        return result;
    }
    static void Main()
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());

        string binaryString = ConvertDecimalToBinary(input);
        MatchCollection matches = Regex.Matches(binaryString, "([0]{3}|[1]{3})");
        List<int> positions = new List<int>();
        foreach (Match match in matches)
        {
            positions.Add(match.Index);
        }
        int[] targetPositions = positions.ToArray();

        StringBuilder builder = new StringBuilder(binaryString);
        for (int i = 0; i < targetPositions.Length; i++)
        {
            if (binaryString[targetPositions[i]] == '1')
            {
                builder.Replace('1', '0', targetPositions[i], 3);
            }
            else 
            {
                builder.Replace('0', '1', targetPositions[i], 3);
            }
        }
        string resultAsString = builder.ToString();
        BigInteger result = ConvertBinaryToDecimal(resultAsString);
        Console.WriteLine(result);
    }
}