using System;
class MagicCarNumbers
{
    static void Main()
    {
        int target = int.Parse(Console.ReadLine());
        int resultCount = 0;
        int[] values = new int[10] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        char[] chars = new char[10] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        for (int j = 0; j < 10; j++)
        {
            for (int k = 0; k < 10; k++)
            {
                for (int p = 0; p < 10; p++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int i = 0; i < chars.Length; i++)
                        {
                            for (int h = 0; h < chars.Length; h++)
                            {
                                if ((j == k && k == p && p == l) || // aaaa  
                                    (j != k && k == p && p == l) || // abbb
                                    (j == k && k == p && p != l) || // aaab
                                    (j == k && p == l && j != p && j != l && k != p && k != l) || // aabb
                                    (j == p && k == l && j != k && k != p && p != l) || // abab
                                    (j == l && k == p && j != k && p != l)) // abba
                                {
                                    int digitsSum = j + k + p + l;
                                    int lettersSum = values[i] + values[h];
                                    int totalSum = 40 + digitsSum + lettersSum;
                                    if (totalSum == target)
                                    {
                                        Console.WriteLine("CA{0}{1}{2}{3}{4}{5}", j, k, p, l, chars[i], chars[h]);
                                        resultCount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(resultCount);
    }
}