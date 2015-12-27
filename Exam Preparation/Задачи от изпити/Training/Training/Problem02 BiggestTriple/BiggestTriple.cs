using System;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbersAsStrings = input.Split(' ');
        if (numbersAsStrings.Length == 1)
        {
            Console.Write("{0} ", numbersAsStrings[0]);
            Environment.Exit(0);
        }
        int lastElementsCount = numbersAsStrings.Length % 3;
        int[] numbers = new int[numbersAsStrings.Length - lastElementsCount];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }

        int currentSum = 0, maxSum = 0, maxSumPosition = 0;
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            counter++;
            if (counter % 3 == 0 && counter != 0)
            {
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumPosition = i;
                    currentSum = 0;
                }
                else
                {
                    currentSum = 0;
                }
            }
        }
        double lastElementsSum = 0;
        int[] lastNumbers = new int[numbersAsStrings.Length - numbers.Length];
        for (int i = numbersAsStrings.Length - lastElementsCount; i < numbersAsStrings.Length; i++)
        {
            lastElementsSum += double.Parse(numbersAsStrings[i]);
        }

        if (Math.Sign(lastElementsSum) == -1)
        {
            if (lastElementsSum < maxSum)
            {
                maxSumPosition = numbersAsStrings.Length - lastElementsCount;
                for (int i = numbers.Length; i < numbersAsStrings.Length; i++)
                {
                    Console.Write("{0} ", numbersAsStrings[i]);
                }
            }
            Environment.Exit(0);
        }
        if (lastElementsSum > maxSum)
        {
            maxSumPosition = numbersAsStrings.Length - lastElementsCount;
            for (int i = numbers.Length; i < numbersAsStrings.Length; i++)
            {
                Console.Write("{0} ", numbersAsStrings[i]);
            }
        }
        else
        {
            if (maxSumPosition >= 2)
            {
                maxSumPosition -= 2;
            }
            for (int i = maxSumPosition; i < maxSumPosition + 3; i++)
            {
                Console.Write("{0} ", numbersAsStrings[i]);
            }
        }
    }
}