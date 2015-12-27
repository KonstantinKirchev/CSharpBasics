using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Calculate Hypotenuse
            // store cathetus in an array
            double[] cat = { 3, 4, 10, 12, 100, 250 };
            // organize cicle with step 2 (there a 2 cathetus in 1 triangle)
            for (int i2 = 0; i2 < 6; i2 = i2 + 2)
            {
                // calculate hipothenuse using Pythagorean theorem
                double hip = Math.Sqrt(cat[i2] * cat[i2] + cat[i2 + 1] * cat[i2 + 1]);
                // print result
                Console.WriteLine("Cathet1 {0}   Cathet2 {1}   Hypotenuse {2}", cat[i2], cat[i2 + 1], hip);
            }
            Console.ReadLine();
        }
    }
}
