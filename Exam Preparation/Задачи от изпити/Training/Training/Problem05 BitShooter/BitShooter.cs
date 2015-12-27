using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class BitShooter
{
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
    public static int[] GetTargetPositions(int center, int size)
    {
        List<int> targets = new List<int>();
        targets.Add(center);
        for (int i = 0; i < size / 2; i++)
        {
            targets.Add(center + (i + 1));
            targets.Add(center - (i + 1));
        }
        int[] targetsPositions = targets.ToArray();
        Array.Sort(targetsPositions);
        List<int> list = new List<int>();
        for (int i = 0; i < targetsPositions.Length; i++)
        {
            if (targetsPositions[i] >= 0 && targetsPositions[i] <= 64)
            {
                list.Add(targetsPositions[i]);
            }
        }
        int[] result = list.ToArray();
        return result;
    }
    static void Main()
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        string binaryString = ConvertDecimalToBinary(input);

        StringBuilder builder = new StringBuilder(binaryString);
        for (int i = 0; i < 3; i++)
        {
            string targets = Console.ReadLine();
            string[] numbersAsStrings = targets.Split(' ');
            int position = int.Parse(numbersAsStrings[0]);
            int length = int.Parse(numbersAsStrings[1]);
            int[] positions = GetTargetPositions(position, length);
            for (int j = 0; j < positions.Length; j++)
            {
                if (positions[j] >= 0 && positions[j] <= 63)
                {
                    if (builder[positions[j]] == '1')
                    {
                        builder.Replace('1', '0', positions[j], 1);
                    }
                }
            }
        }
        string finalString = builder.ToString();
        int rightCount = 0;
        for (int i = 0; i < finalString.Length / 2; i++)
        {
            if (finalString[i] == '1')
            {
                rightCount++;
            }
        }
        int leftCount = 0;
        for (int i = finalString.Length / 2; i < finalString.Length; i++)
        {
            if (finalString[i] == '1')
            {
                leftCount++;
            }
        }
        Console.WriteLine("left: {0}", leftCount);
        Console.WriteLine("right: {0}", rightCount);
    }
}