using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Numerics;
class Program
{
    public static int CountBits(int number)
    {
        int temp = number;
        int count = 0;

        while (temp != 0)
        {
            if ((temp & 1) == 1 || (temp & 1) == 0)
            {
                count++;
            }
            temp >>= 1;
        }
        return count;
    }
    public static string ConvertDecimalToBinary(BigInteger number)
    {
        List<BigInteger> temp = new List<BigInteger>();
        for (int i = 0; i < 64; i++)
        {
            temp.Add(number & 1);
            number = number >> 1;
        }
        //temp.Reverse();

        StringBuilder builder = new StringBuilder();
        foreach (int digit in temp)
        {
            builder.Append(digit);
        }
        string result = builder.ToString();
        return result;
    }

    public static string Reverse(string text)
    {
        if (text == null) return null;

        // this was posted by petebob as well 
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new String(array);
    }


    static void Main()
    {

        // change even bits

        int numbersCount = int.Parse(Console.ReadLine());
        int[] positionsCount = new int[numbersCount];
        for (int i = 0; i < numbersCount; i++)
        {
            positionsCount[i] = CountBits(int.Parse(Console.ReadLine()));
        }

        string input = ConvertDecimalToBinary(int.Parse(Console.ReadLine()));
        // string binaryString = input.TrimStart('0');
        StringBuilder builder = new StringBuilder(input);


        int changeCounter = 0;
        for (int i = 0; i < positionsCount.Length; i++)
        {
            int length = positionsCount[i] * 2;
            if (builder.Length < length)
            {
                builder.Insert(builder.Length, "0", length - builder.Length);
            }

            for (int k = 0; k < length; k += 2)
            {
                if (builder[k] == '0')
                {
                    builder.Replace('0', '1', k, 1);
                    changeCounter++;
                }
            }

            while (builder[builder.Length - 1] == '0')
            {
                builder.Remove(builder.Length - 1, 1);
            }




        }

        string result = builder.ToString();
        string final = Reverse(result);
        Console.WriteLine(Convert.ToUInt64(final, 2));
        Console.WriteLine(changeCounter);



    }
}