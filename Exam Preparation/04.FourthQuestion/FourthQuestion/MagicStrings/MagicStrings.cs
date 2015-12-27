using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };

        int resultsCount = 0;
        for (int d1 = 0; d1 < letters.Length; d1++)
        {
            for (int d2 = 0; d2 < letters.Length; d2++)
            {
                for (int d3 = 0; d3 < letters.Length; d3++)
                {
                    for (int d4 = 0; d4 < letters.Length; d4++)
                    {
                        string left = "" + letters[d1] + letters[d2] + letters[d3] + letters[d4]; // вкарвам всички комбинации от букви в стринг
                        int weightLeft = CalcWeight(left); // после отивам в метода и им взимам тежестта и събирам общата им тежест на 4те леви букви
                        for (int d5 = 0; d5 < letters.Length; d5++)
                        {
                            for (int d6 = 0; d6 < letters.Length; d6++)
                            {
                                for (int d7 = 0; d7 < letters.Length; d7++)
                                {
                                    for (int d8 = 0; d8 < letters.Length; d8++)
                                    {
                                        string right = "" + letters[d5] + letters[d6] + letters[d7] + letters[d8];
                                        int weightRight = CalcWeight(right); // тука правя същото за десните
                                        if (Math.Abs(weightLeft - weightRight) == diff) // намирам разликата в тежестите на левите и десните и ако тя е равна на diff
                                        {
                                            Console.WriteLine(left + right); // ги отпечатвам
                                            resultsCount++; 
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcWeight(string str)
    {
        int weight = 0;
        foreach (var ch in str)
        {
            switch (ch)
            {
                case 's': weight += 3; break;
                case 'n': weight += 4; break;
                case 'k': weight += 1; break;
                case 'p': weight += 5; break;
            }
        }
        return weight;
    }
}