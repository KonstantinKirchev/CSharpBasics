using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);
        long currentNumber = 0;
        long result = 0;

        for (int i = 0; i < n; i++)
        {

            input = Console.ReadLine();

            currentNumber = long.Parse(input);

            result ^= currentNumber;

        }

        Console.WriteLine(result);




    }
}

