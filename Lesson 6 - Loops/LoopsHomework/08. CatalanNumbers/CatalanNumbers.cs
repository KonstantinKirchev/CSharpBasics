using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 1 && n < 100)
            {
                BigInteger factorialN = 1;
                BigInteger multiplicationN = 1;
                BigInteger sumN = 1;
                BigInteger result = 0;
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int j = 1; j <= 2 * n; j++)
                {
                    multiplicationN *= j;
                }
                for (int k = 1; k <= n + 1; k++)
                {
                    sumN *= k;
                }
                result = multiplicationN / (sumN * factorialN);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Main();
        }
    }

