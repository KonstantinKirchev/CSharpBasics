using System;
using System.Numerics;

    class CalculateN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            if (n > 1 && n < 100 && k > 1 && k < 100 && n > k)
            {
                BigInteger factorialN = 1;
                BigInteger factorialK = 1;
                BigInteger result = 0;
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int j = 1; j <= k; j++)
                {
                    factorialK *= j;
                }
                result = factorialN / factorialK;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }           
            Main();
        }
    }

