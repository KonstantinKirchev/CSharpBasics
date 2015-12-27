using System;
using System.Linq;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] catNumbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            catNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(catNumbers);
        int target = catNumbers.GroupBy(i => i).OrderByDescending(g => g.Count()).First().Key;
        Console.WriteLine(target);

    }
}
