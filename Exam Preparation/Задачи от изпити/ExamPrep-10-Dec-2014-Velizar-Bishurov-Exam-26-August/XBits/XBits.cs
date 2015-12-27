using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBits
{
    class Xbits
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int bit = 0; bit < 30; bit++)
                {
                    int topNumber = numbers[i];
                    int middleNumber = numbers[i + 1];
                    int bottomNumber = numbers[i + 2];
                    if (((topNumber >> bit) & 7) == 5 && ((middleNumber >> bit) & 7) == 2 &&
                        ((bottomNumber >> bit) & 7) == 5)
                    {
                        counter++;
                    }
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}
