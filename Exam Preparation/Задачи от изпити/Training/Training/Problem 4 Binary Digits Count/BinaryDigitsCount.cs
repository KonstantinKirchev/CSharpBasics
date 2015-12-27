using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class BinaryDigitsCount
{
    static void Main()
    {

        string target = Console.ReadLine();
        
        int numbersCount = int.Parse(Console.ReadLine());
        uint[] numbersAsDecimals = new uint[numbersCount];
        
        for(int i = 0; i < numbersAsDecimals.Length; i++)
        {
            numbersAsDecimals[i] = uint.Parse(Console.ReadLine()); 
        }

        string[] numbersAsBinaryString = new string[numbersCount];
        List<uint> temp = new List<uint>();

        for (int i = 0; i < numbersAsDecimals.Length; i++)
        {
            numbersAsBinaryString[i] = Convert.ToString(numbersAsDecimals[i], 2);
            
        }
        
        
        int[] results = new int[numbersAsBinaryString.Length];
        for(int i = 0; i < numbersAsBinaryString.Length; i++)
        {
            MatchCollection matches = Regex.Matches(numbersAsBinaryString[i], target);
            results[i] = matches.Count;

        }

        for(int i = 0; i < results.Length; i++)
        {
            Console.WriteLine(results[i]);
        }
        
        
    }

}

