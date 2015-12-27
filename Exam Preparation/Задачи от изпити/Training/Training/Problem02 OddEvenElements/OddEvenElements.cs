using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        // 93 points
        string input = Console.ReadLine();
        if (input == string.Empty)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            Environment.Exit(0);
        }
        double[] numbers = input.Split(' ').Select(digit => Convert.ToDouble(digit)).ToArray();
        if (numbers.Length == 1)
        {
            Console.WriteLine(string.Format("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", numbers[0].ToString().Trim()));
        }
        else
        {
            List<double> oddList = new List<double>();
            List<double> evenList = new List<double>();
            double evenSum = 0, oddSum = 0;
            for (int odd = 0, even = 1; odd < numbers.Length; odd += 2, even += 2)
            {
                if (odd <= numbers.Length - 1 && even <= numbers.Length - 1)
                {
                    oddList.Add(numbers[odd]);
                    evenList.Add(numbers[even]);
                    oddSum += numbers[odd];
                    evenSum += numbers[even];
                }
            }
            if (numbers.Length % 2 > 0)
            {
                oddList.Add(numbers[numbers.Length - 1]);
                oddSum += numbers[numbers.Length - 1];
            }
            double[] oddNumbers = oddList.ToArray();
            double[] evenNumbers = evenList.ToArray();
            Array.Sort(oddNumbers);
            double oddMin = oddNumbers[0];
            Array.Reverse(oddNumbers);
            double oddMax = oddNumbers[0];
            Array.Sort(evenNumbers);
            double evenMin = evenNumbers[0];
            Array.Reverse(evenNumbers);
            double evenMax = evenNumbers[0];

            Console.WriteLine("OddSum={0:}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
            oddSum.ToString().Trim(), oddMin.ToString().Trim(), oddMax.ToString().Trim(), evenSum.ToString().Trim(), evenMin.ToString().Trim(), evenMax.ToString().Trim());
        }
    }
}