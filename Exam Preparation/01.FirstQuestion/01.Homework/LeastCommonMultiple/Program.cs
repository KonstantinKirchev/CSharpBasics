using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 6. Least Common Multiple
            int n1 = 1234;
            int n2 = 3456;
            // declare arrays for decomposition
            int[] n1Decompposition = new int[100];
            int[] n2Decomposition = new int[100];
            // decomposition n1 and n2 into arrays n1Decomposition and n2Decomposition
            n1Decompposition = DecompNumber(n1);
            n2Decomposition = DecompNumber(n2);
            // remove the repetitive numbers in the second array
            for (int i = 1; i <= n1Decompposition[0]; i++)
            {
                for (int j = 1; j <= n2Decomposition[0]; j++)
                {
                    if (n1Decompposition[i] == n2Decomposition[j])
                    {
                        // if there are equal numbers in the 2 arrays we remove the number from the seccond array (n2Decomposition)
                        for (int k = j; k < n2Decomposition[0]; k++)
                        {
                            n2Decomposition[k] = n2Decomposition[k + 1];
                        }
                        n2Decomposition[n2Decomposition[0]] = 0;
                        if (n2Decomposition[0] > 0)
                        {
                            n2Decomposition[0] = n2Decomposition[0] - 1;
                        }
                    }
                }
            }
            // calculate LCM (n1,n2)
            int result = 1;
            for (int i = 1; i <= n1Decompposition[0]; i++) { result = result * n1Decompposition[i]; }
            for (int i = 1; i <= n2Decomposition[0]; i++) { result = result * n2Decomposition[i]; }
            Console.WriteLine("LOL ( {0}, {1} )= {2}", n1.ToString(), n2.ToString(), result.ToString());
        }

        static int[] DecompNumber(int n)
        {
            // Decomposition of the number n of simple multipliers
            int[] result = new int[100];
            int index = 1;
            int n2 = n;
            // check for count of zeros of the end of n 
            while (n2 % 10 == 0)
            {
                n2 = n2 / 10;
                result[index] = 2;
                result[index + 1] = 5;
                index = index + 2;
            }
            if (n2 == 1) { goto DN2; }
            // check if n2 is divided on prime numbers from 2 to 100-th prime number 
            int prNum = 2;
        DN1:
            while (n2 % prNum == 0)
            {
                n2 = n2 / prNum;
                result[index] = prNum;
                index++;
                if (n2 == 1) { goto DN2; }
            }
            prNum = NextPrimeNum(prNum);
            goto DN1;
        DN2:
            result[0] = index - 1;
            return result;
        }

        static int NextPrimeNum(int n)
        {
        NPN1:
            n++;
            if (n < 1) { return 1; }
            if (n == 1 || n == 2) { return n; }

            int flagPrime = 1;
            if (n == 4) { flagPrime = 0; }
            // check if number i is divisible by numbers from 2 to number/2 without remainder - if yes number is not prime
            for (int i = 2; i <= (n / 2); i++)
            {
                int x = n % i;
                if (x == 0)
                {
                    flagPrime = 0;
                    break;
                }
            }
            if (flagPrime == 0) { goto NPN1; }
            return n;
        }
    }
}
