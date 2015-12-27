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
class LettersSymbolsNumbers
{

    public static int CalculateLetterValue(char letter)
    {
        int sum = 0;
        for(char i = (char)65; i <= (char)90; i++)
        {
            if ( letter == (char)i )
            {
                sum +=  Convert.ToInt32(string.Format("{0}{1}", i - 64, 0));
            }
        }
        return sum;
    }

    static void Main()
    {
        // letters symbols

        int stringCount = int.Parse(Console.ReadLine());
        string tempInput = string.Empty;
        for (int i = 0; i < stringCount; i++)
        {
            tempInput += Console.ReadLine();
        }
        string input = Regex.Replace(tempInput, @"\s+", "");

        BigInteger symolSum = 0;
        MatchCollection symbolMatches = Regex.Matches(input, @"[`~!@#$%^&*()_+=\/[{\]};:<>|./?,\\'""-]");
        foreach (Match match in symbolMatches)
        {
            symolSum += 200;
        }

        BigInteger digitSum = 0;
        MatchCollection digitsMatches = Regex.Matches(input, "[0-9]");
        foreach (Match match in digitsMatches)
        {
            digitSum += Convert.ToInt32(match.Value) * 20;
        }

        BigInteger letterSum = 0;
        MatchCollection letterMatches = Regex.Matches(input, "[A-Z a-z]");
        foreach (Match letter in letterMatches)
        {
            letterSum += CalculateLetterValue(Convert.ToChar(letter.Value.ToUpper()));
        }
        
        Console.WriteLine(letterSum);
        Console.WriteLine(digitSum);
        Console.WriteLine(symolSum);
    }
}