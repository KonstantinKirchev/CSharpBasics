using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToePower
{
    class TicTacToePower
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int initialValue = int.Parse(Console.ReadLine());

            int index = y * 3 + x + 1;
            int trueValue = initialValue + index - 1;
            long powered = (long)Math.Pow(trueValue, index);
            Console.WriteLine(powered);
        }
    }
}
