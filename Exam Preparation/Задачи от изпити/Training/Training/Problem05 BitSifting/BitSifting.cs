using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;

class BitSifting
{
    public static string ConvertDecimalToBinary(ulong number)
    {
        List<ulong> temp = new List<ulong>();
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
    public static int[] GetTargetPositionsInBinaryString(string binaryString, char target, int bitsCount)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < bitsCount; i++)
        {
            if (binaryString[i] == target)
            {
                list.Add(i);
            }
        }
        int[] positions = list.ToArray();
        return positions;
    }

    static void Main()
    {

        ulong input = ulong.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());
        ulong[] numbers = new ulong[numbersCount];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ulong.Parse(Console.ReadLine());
        }

        string inputInBinary = ConvertDecimalToBinary(input);
        string[] numbersInBinary = new string[numbersCount];
        for (int i = 0; i < numbersInBinary.Length; i++)
        {
            numbersInBinary[i] = ConvertDecimalToBinary(numbers[i]);
        }

        int[] positions = GetTargetPositionsInBinaryString(inputInBinary, '1', 64); // Gets the positions where "1" can be found in the input number. 
        List<int> zeroesPositionsList = new List<int>();
        for (int i = 0; i < numbersInBinary.Length; i++)
        {
            for (int j = 0; j < positions.Length; j++)
            {
                if (numbersInBinary[i][positions[j]] == '0')  // If there's "0" in the number at the specified position, add the current position.
                {
                    zeroesPositionsList.Add(positions[j]);
                }
            }
        }
        int[] zeroesPositions = zeroesPositionsList.ToArray(); // Put all positions where "0" is found in one int array and then sort it.
        Array.Sort(zeroesPositions);

        int resultCount = 0;
        for (int i = 0; i < positions.Length; i++)
        {
            int startingPosition = Array.IndexOf(zeroesPositions, positions[i]);   // Calculates how many times a certain number can be found, in this case the number is the position of zeroes.
            int endingPosition = Array.LastIndexOf(zeroesPositions, positions[i]);
            int length = (endingPosition - startingPosition) + 1;
            if (length == numbersCount) // If a given number(position of zeroes) is found as many times as there are numbers to sort trough then there's only zeroes in that position, therefore the bit will fall trough.
            {
                resultCount++;
            }
        }

        if (numbersCount == 0) // If there are no numbers to check all the bits with a value of "1" from the original number will fall trough.
        {
            Console.WriteLine(positions.Length);
        }
        else if (numbersCount == 1) // If there's only one number, there are as many bits as there are zeroes in the number to sort trough.
        {
            Console.WriteLine(zeroesPositions.Length);
        }
        else
        {
            Console.WriteLine(resultCount);
        }
    }
}