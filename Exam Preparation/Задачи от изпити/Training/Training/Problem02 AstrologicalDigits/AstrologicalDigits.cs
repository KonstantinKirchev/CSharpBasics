using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        string numberAsString = Console.ReadLine();

        BigInteger[] digits = Regex.Replace(numberAsString, "[^0-9]", "").Select(x => (BigInteger)Char.GetNumericValue(x)).ToArray();
        BigInteger sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }

        int rem = 0;
        int finalsum = 0;
        while (sum > 0)
        {
            while (sum != 0)
            {
                rem = (int)sum % 10;
                finalsum = finalsum + rem;
                sum = sum / 10;
            }
            if (finalsum > 9)
            {
                sum = finalsum;
                finalsum = 0;
            }
        }
        Console.WriteLine(finalsum);
    }
}