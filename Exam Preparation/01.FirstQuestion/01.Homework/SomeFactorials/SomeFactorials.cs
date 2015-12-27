using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SomeFactorials
{
    class SomeFactorials
    {
        static void Main(string[] args)
        {
            // 3.  Some Factorials
            // put mumbers into array f1
            int[] f1 = { 100, 171, 250 };
            for (int i1 = 0; i1 < 3; i1++)
            {
                // calculate factoriel from f1[i1] in Big integer sum
                BigInteger sum = 1;
                int index = (f1[i1]);
                for (int k = 2; k <= index; k++)
                {
                    sum = sum * k;
                }
                // print number and number! on screen
                Console.WriteLine("{0}! = {1}", f1[i1], sum);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
