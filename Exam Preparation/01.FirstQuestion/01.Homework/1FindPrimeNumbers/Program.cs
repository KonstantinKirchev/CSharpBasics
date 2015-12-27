using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FindPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Problem 1.Find the 24th, 101st and 251st prime number.
            //int counter = 0;
            //for (int i = 1; i < 10000; i++)
            //{
            //    int flagPrime = 2;
            //    if (i == 4) { flagPrime = 0; }
            //    // check if number i is divisible by numbers from 2 to number/2 without remainder - if yes number is not prime
            //    for (int j = 2; j <= (i / 2); j++)
            //    {
            //        int x = i % j;
            //        if (x == 0)
            //        {
            //            flagPrime = 0;
            //            break;
            //        }
            //    }
            //    if (flagPrime == 2)
            //    {
            //        // in counter we count number of found prime numbers
            //        counter = counter + 1;
            //        // and print 24-th, 101-st and 251-st prime numbers
            //        if (counter == 25 || counter == 102 || counter == 252)
            //        {
            //            Console.WriteLine("{0} - {1}", counter-1, i);
            //        }
            //        if (counter == 252) { break; }
            //    }
            //}
            //Console.ReadLine();
            int f = 2748;
            Console.WriteLine(Convert.ToString(f,2).PadLeft(16,'0'));
        }
    }
}
