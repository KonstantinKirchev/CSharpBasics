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
    public static string ConvertDecimalToBinary(int number)
    {
        List<int> temp = new List<int>();
        for (int i = 0; ; i++)
        {
            temp.Add(number & 1);
            number = number >> 1;
            if(number == 0)
            {
                break;
            }
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

    public static string InvertBinaryString(string binaryString)
    {
        char[] array = new char[binaryString.Length];
        string result = string.Empty;
        for(int i = 0; i < array.Length; i++)
        {   
            if(binaryString[i] == '0')
            {
                result += 1;
            }
            else
            {
                result += 0;
            }
            
        }
        return result;
    }

    public static string InvertBinaryString(string binaryString, int[] positions) 
    {
        char[] array = new char[binaryString.Length];
        StringBuilder builder = new StringBuilder(binaryString);
        for (int i = 0; i < positions.Length; i++)
        {
            if (positions[i] <= builder.Length && builder[positions[i]] == '0')
            {
                builder.Replace('0', '1', positions[i], 1);
            }
            

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
            if (i % step + 1 == 1)
            {
                temp.Add(i);
            }
        }
        int[] positions = temp.ToArray();
        return positions;
    }

    public static string ReverseBinaryString(string binaryString)
    {
        char[] array = binaryString.ToCharArray();
        Array.Reverse(array);
        string result = string.Empty;
        for(int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        
        return result;
    }

    public static int ConvertBinaryToDecimal(string input)
    {

        UInt64 number = Convert.ToUInt64(input, 2);
        int result = Convert.ToInt32(number);
        return result;
    }
  

    static void Main()
    {

        
        


        //We All Love Bitssss 
        //int numbersCount = int.Parse(Console.ReadLine());
        //int[] numbers = new int[numbersCount]; 
        //for(int i = 0; i < numbersCount; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());

        //    string currentNumber = ConvertDecimalToBinary(numbers[i]);
        //    int P = ConvertBinaryToDecimal(currentNumber);

        //    string invertedNumber = InvertBinaryString(currentNumber);
        //    int invertedP = ConvertBinaryToDecimal(invertedNumber);

        //    string reversedNumber = ReverseBinaryString(currentNumber);
        //    int reversedP = ConvertBinaryToDecimal(reversedNumber);

        //    int result = (P ^ invertedP) & reversedP;
        //    Console.WriteLine(result);

        //}
    }
}