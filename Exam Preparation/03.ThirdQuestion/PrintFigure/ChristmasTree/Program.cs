using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '\u00A9';
            Console.OutputEncoding = Encoding.Unicode;

            double count = 1;
            int red = 5;
            double col = 2 * red - 1;
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j < (col / 2 - count / 2) || j > (col / 2 + count / 2 - 1))
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write(symbol);
                }
                count = count + 2;
                Console.WriteLine();
            }
        }
    }
}