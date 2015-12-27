using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Disk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            int centerX = n / 2;
            int centerY = n / 2;

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    int distY = Math.Abs(centerY - i);
                    int distX = Math.Abs(centerX - k);
                    double distanceToCenter = Math.Sqrt(distX*distX + distY*distY);

                    if (distanceToCenter <= r)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
