using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class SequenceOfKNumbers
{
    static void Main()
    {
        //sequence of K numbers 80/100 the regex does not work for two digit numbers aka number > 9 !!!!!!!!!!!!!!!!!!!!!!
        string numbers = Console.ReadLine();
        int duplicatesCount = int.Parse(Console.ReadLine());
        if (duplicatesCount == 1)
        {
            Environment.Exit(0);
        }
        if (duplicatesCount == 0)
        {
            Console.WriteLine(numbers);
            Environment.Exit(0);
        }

        StringBuilder builder = new StringBuilder(numbers);
        builder.Replace(" ", "");
        string joinedNumbers = builder.ToString();
        builder.Clear();

        if(duplicatesCount >= joinedNumbers.Length)
        {
            Console.WriteLine(" ");
            Environment.Exit(0);
        }

        List<string> original = new List<string>();
        foreach (var item in joinedNumbers)
        {
            original.Add(Convert.ToString(item));
        }

        string regex1 = "[0]{" + duplicatesCount + "}|" + "[1]{" + duplicatesCount + "}|" + "[2]{" + duplicatesCount + "}|" + "[3]{" + duplicatesCount + "}|" + "[4]{" + duplicatesCount + "}|" + "[5]{" + duplicatesCount + "}|" + "[6]{" + duplicatesCount + "}|" + "[7]{" + duplicatesCount + "}|" + "[8]{" + duplicatesCount + "}|" + "[9]{" + duplicatesCount + "}";

        // string regex = "[0]{2,}|[1]{2,}|[2]{2,}|[3]{2,}|[4]{2,}|[5]{2,}|[6]{2,}|[7]{2,}|[8]{2,}|[9]{2,}";

        MatchCollection matches = Regex.Matches(joinedNumbers, regex1);
        List<int> dupes = new List<int>();
        foreach (Match match in matches)
        {
            dupes.Add(match.Index);
            for (int i = 1; i < duplicatesCount; i++)
            {
                dupes.Add(match.Index + i);
            }
        }
        int[] positions = dupes.ToArray();

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0, j = 0; i < joinedNumbers.Length; i++)
        {
            if (j < positions.Length && i == positions[j])
            {
                j++;
                continue;
            }
            else
            {
                stringBuilder.Append(joinedNumbers[i]);
            }
        }
        string finalResult = stringBuilder.ToString();
        foreach (char digit in finalResult)
        {
            Console.Write("{0} ", digit);
        }
    }
}