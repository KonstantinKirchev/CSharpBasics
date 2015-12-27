using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;


class FriendBits
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
        if (input == 0)
        {
            Console.WriteLine(0);
            Console.WriteLine(0);
            Environment.Exit(0);
        }
        string binaryString = ConvertDecimalToBinary(input);

        MatchCollection matches = Regex.Matches(binaryString, "[0]{2,32}|[1]{2,32}");
        StringBuilder friendBuilder = new StringBuilder();
        List<int> list = new List<int>();
        foreach (Match match in matches)
        {
            friendBuilder.Append(match.Value);
            list.Add(match.Index);
            for (int i = 1; i < match.Length; i++)
            {
                list.Add(match.Index + i);
            }
        }
        int[] positions = list.ToArray();
        StringBuilder loneWolfBuilder = new StringBuilder();
        for (int i = 0, j = 0; i < binaryString.Length; i++)
        {
            if (j < positions.Length && i == positions[j])
            {
                j++;
                continue;
            }
            else
            {
                loneWolfBuilder.Append(binaryString[i]);
            }
        }
        string alone = loneWolfBuilder.ToString();
        BigInteger aloneResult = 0;
        if (alone == string.Empty)
        {
            aloneResult = 0;
        }
        else
        {
            aloneResult = ConvertBinaryToDecimal(alone);
        }
        string friends = friendBuilder.ToString();
        BigInteger friendResult = ConvertBinaryToDecimal(friends);

        Console.WriteLine(friendResult);
        Console.WriteLine(aloneResult);
    }
}