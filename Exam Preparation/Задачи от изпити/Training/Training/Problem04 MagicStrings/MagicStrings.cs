using System;

class MagicStrings
{
    static void Main()
    {
        int target = int.Parse(Console.ReadLine());

        int resultsCount = 0;
        int[] numbers = new int[4] { 1, 4, 5, 3 };
        char[] chars = new char[4] { 'k', 'n', 'p', 's' };
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    for (int l = 0; l < numbers.Length; l++)
                    {
                        int sumOne = numbers[i] + numbers[j] + numbers[k] + numbers[l];

                        for (int i2 = 0; i2 < numbers.Length; i2++)
                        {
                            for (int j2 = 0; j2 < numbers.Length; j2++)
                            {
                                for (int k2 = 0; k2 < numbers.Length; k2++)
                                {

                                    for (int l2 = 0; l2 < numbers.Length; l2++)
                                    {
                                        int sumTwo = numbers[i2] + numbers[j2] + numbers[k2] + numbers[l2];

                                        if (sumTwo - sumOne == target || sumOne - sumTwo == target)
                                        {
                                            string first = chars[i] + "" + chars[j] + "" + chars[k] + "" + chars[l];
                                            string second = chars[i2] + "" + chars[j2] + "" + chars[k2] + "" + chars[l2];
                                            Console.WriteLine(first + second);
                                            resultsCount++;
                                            first = string.Empty;
                                            second = string.Empty;
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
}