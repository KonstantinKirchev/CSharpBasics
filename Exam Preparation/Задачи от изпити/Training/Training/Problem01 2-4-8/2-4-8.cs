using System;
using System.Numerics;

class Problem01TwoFourEight
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());

        if (b == 2)
        {
            BigInteger result = a % c;
            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result % 4);
                Console.WriteLine(result);
            }
        }
        if (b == 4)
        {
            BigInteger result = a + c;
            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result % 4);
                Console.WriteLine(result);
            }
        }
        if (b == 8)
        {
            BigInteger result = a * c;
            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result % 4);
                Console.WriteLine(result);
            }
        }
    }
}