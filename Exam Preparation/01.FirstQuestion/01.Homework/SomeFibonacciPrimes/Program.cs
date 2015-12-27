using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeFibonacciPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem2:  Some Fibonacci Primes
            // declare array from 101 int64 elements
            Int64[] f = new Int64[100];
            f[0] = 1;
            f[1] = 1;
            // find next Fibonacci number as a sum of preveus 2 numbers in array
            for (int i = 2; i < 99; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                // check if 24th, 101st and 251st prime numbers are part of the base Fibonacci number set and print them
                if (f[i] == 89 || f[i] == 547 || f[i] == 1597)
                {
                    Console.WriteLine("position {0} - number {1} ", i+2, f[i]);
                }
            }
            // 24th, 101st and 251st prime numbers are not part of the base Fibonacci number set.
            Console.WriteLine("24th, 101st and 251st prime numbers are not part of the base Fibonacci number set.");
            Console.ReadLine();
        }
    }
}
