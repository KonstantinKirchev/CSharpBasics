using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class Program
{

    static void Main()
    {

        //Problem02 Illuminati 80 from 100 
        string input = Console.ReadLine();

        string[] vowels = new string[] { "A", "E", "I", "O", "U" };
        List<int> vowelsCount = new List<int>();
        for (int i = 0; i < vowels.Length; i++)
        {
            MatchCollection matches = Regex.Matches(input, vowels[i], RegexOptions.IgnoreCase);
            vowelsCount.Add(matches.Count);
        }
        int[] results = vowelsCount.ToArray();
        int matchesCount = 0;
        long sum = 0L;
        for(int i = 0; i < results.Length; i++)
        {
            matchesCount += results[i];
            if(i == 0)
            {
                sum += results[i] * 65; // A     
            }
            if(i == 1)
            {
                sum += results[i] * 69; // E
            }
            if(i == 2)
            {
                sum += results[i] * 73; // I
            }
            if (i == 3)
            {
                sum += results[i] * 79; // O
            }
            if (i == 4)
            {
                sum += results[i] * 85; // U 
            }
        }
        Console.WriteLine(matchesCount);
        Console.WriteLine(sum);
    }
}
