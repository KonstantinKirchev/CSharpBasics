using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static int CalculateWeight(string input)
    {
        int weight = 0;
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        dictionary.Add('a', 5);
        dictionary.Add('b', -12);
        dictionary.Add('c', 47);
        dictionary.Add('d', 7);
        dictionary.Add('e', -32);
        for (int i = 0; i < input.Length; i++)
        {
            weight += (i + 1) * dictionary[input[i]];
        }
        return weight;
    }
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int resultCount = 0;
        int[] numbers = new int[5] { 5, -12, 47, 7, -32 };
        char[] chars = new char[5] { 'a', 'b', 'c', 'd', 'e', };
        List<string> results = new List<string>();
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    for (int l = 0; l < numbers.Length; l++)
                    {
                        for (int m = 0; m < numbers.Length; m++)
                        {
                            string currentString = chars[i] + "" + chars[j] + "" + chars[k] + "" + chars[l] + chars[m];
                            string modString = new string(currentString.Distinct().ToArray());
                            int currentWeight = CalculateWeight(modString);
                            if (currentWeight >= start && currentWeight <= end)
                            {
                                results.Add(currentString);
                                resultCount++;
                            }
                            currentString = string.Empty;
                            modString = string.Empty;
                            currentWeight = 0;
                        }
                    }
                }
            }
        }
        if (resultCount == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (string result in results)
            {
                Console.Write("{0} ", result);
            }
        }
    }
}