using System;
using System.Linq;

class NakovsMatching
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int maxWeight = int.Parse(Console.ReadLine());

        bool resultFound = false;

        for (int firstDivider = 1; firstDivider < firstWord.Length; firstDivider++) // този цикъл е за първата дума
        {
            for (int secondDivider = 1; secondDivider < secondWord.Length; secondDivider++) // този за втората дума
            {
                string firstLeft = firstWord.Substring(0, firstDivider); // тук режа думата на лява и дясна част чрез функцията Substring
                string firstRight = firstWord.Substring(firstDivider);
                string secondLeft = secondWord.Substring(0, secondDivider);
                string secondRight = secondWord.Substring(secondDivider);
                //Console.Write("{0}|{1}", firstLeft, firstRight);
                //Console.WriteLine("      {0}|{1}", secondLeft, secondRight);

                long firstLeftWeight = CalculateWeight(firstLeft); // тук изчислявам теглото на първата дума лявата и част като си викам метода
                long firstRightWeight = CalculateWeight(firstRight);
                long secondLeftWeight = CalculateWeight(secondLeft);
                long secondRightWeight = CalculateWeight(secondRight);
                //Console.Write("{0}|{1}", firstLeftWeight, firstRightWeight);
                //Console.WriteLine("      {0}|{1}", secondLeftWeight, secondRightWeight);

                long nakovWeight = Math.Abs(firstLeftWeight * secondRightWeight - secondLeftWeight * firstRightWeight); // формулата я вземам от условието
                if (nakovWeight <= maxWeight) // ако наковото тегло е по-малко от максималното тегло което ми е дадено в началото влизам в if и отпечатвам резултата
                {
                    resultFound = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                        firstLeft, firstRight, secondLeft, secondRight, nakovWeight);
                }
            }
        }

        if (!resultFound)
        {
            Console.WriteLine("No");
        }
    }

    static long CalculateWeight(string word)
    {
        long sum = 0;
        for (int i = 0; i < word.Length; i++)
        {
            sum += (int)word[i]; // тук вземам всяка буква и я сумирам със следващата и така до края на думата
        }

        return sum;
    }
}


             

