using System;
using System.Collections.Generic;
class InsideBuilding
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        List<string> results = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x >= 0 && x <= size && y >= 0 && y <= size) // leftmost square
            {
                results.Add("inside");
            }
            else if (x >= size && x <= size * 2 && y >= 0 && y <= size * 4) // middle
            {
                results.Add("inside");
            }
            else if (x >= size * 2 && x <= size * 3 && y >= 0 && y <= size) // rightmost square
            {
                results.Add("inside");
            }
            else // outside
            {
                results.Add("outside");
            }
        }
        foreach (string result in results)
        {
            Console.WriteLine("{0}", result);
        }
    }
}