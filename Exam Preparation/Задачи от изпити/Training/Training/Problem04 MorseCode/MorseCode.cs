using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Linq;

class MorseCode
{
    public static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        for (int i = 0, j = 1; i < number.ToString().Length; i++, j *= 10)
        {
            int digit = (number / j) % 10;
            sum += digit;
        }
        return sum;
    }
    public static void PrintResult(int a, int b, int c, int d, int e, int f)
    {
        const int size = 6;
        int[] values = new int[size] { a, b, c, d, e, f };
        for (int i = 0; i < size; i++)
        {
            if (values[i] == 0) Console.Write("-----|");

            else if (values[i] == 1) Console.Write(".----|");

            else if (values[i] == 2) Console.Write("..---|");

            else if (values[i] == 3) Console.Write("...--|");
           
            else if (values[i] == 4) Console.Write("....-|");
           
            else if (values[i] == 5) Console.Write(".....|");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        // MorseCodeNumbers
        int number = int.Parse(Console.ReadLine());
        int sum = CalculateSumOfDigits(number);
        bool isFound = false;

        for (int a = 0; a <= 5; a++)
        {
            for (int b = 0; b <= 5; b++)
            {
                for (int c = 0; c <= 5; c++)
                {
                    for (int d = 0; d <= 5; d++)
                    {
                        for (int e = 0; e <= 5; e++)
                        {
                            for (int f = 0; f <= 5; f++)
                            {
                                if (a * b * c * d * e * f == sum)
                                {
                                    PrintResult(a, b, c, d, e, f);
                                    isFound = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (isFound == false)
        {
            Console.WriteLine("No");
        }
    }
}