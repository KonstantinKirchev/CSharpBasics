using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinningNumbers
{
    class WinningNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int letSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                letSum += input[i] - 'a' + 1;
            }

            int counter = 0;
            for (int digit1 = 1; digit1 <=9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        if (digit1*digit2*digit3 == letSum)
                        {
                            for (int digit4 = 1; digit4 <=9; digit4++)
                            {
                                for (int digit5 = 1; digit5 <=9; digit5++)
                                {
                                    for (int digit6 = 1; digit6 <= 9; digit6++)
                                    {
                                        if (digit4*digit5*digit6==letSum)
                                        {
                                            Console.WriteLine("{0}{1}{2}-{3}{4}{5}"
                                                ,digit1,digit2,digit3,digit4,digit5,digit6);
                                            counter++;
                                        } 
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
