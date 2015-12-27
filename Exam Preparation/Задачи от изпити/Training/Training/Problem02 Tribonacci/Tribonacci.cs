using System;
using System.Numerics;

class Tribonacci
{

    static void Main()
    {
        BigInteger numberOne = BigInteger.Parse(Console.ReadLine());
        BigInteger numberTwo = BigInteger.Parse(Console.ReadLine());
        BigInteger numberThree = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 0;

        if (n == 1)
        {
            Console.WriteLine(numberOne);
            Environment.Exit(0);
        }
        if (n == 2)
        {
            Console.WriteLine(numberTwo);
            Environment.Exit(0);
        }
        if (n == 3)
        {
            Console.WriteLine(numberThree);
            Environment.Exit(0);
        }

        for (int i = 4; i <= n; i++)
        {
            result = numberOne + numberTwo + numberThree;
            numberOne = numberTwo;
            numberTwo = numberThree;
            numberThree = result;

        }

        Console.WriteLine(result);


    }
}
