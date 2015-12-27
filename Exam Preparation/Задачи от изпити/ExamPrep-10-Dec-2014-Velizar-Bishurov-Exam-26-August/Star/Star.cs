using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;
            int height = n * 2 - (n / 2 - 1);
            int topMiddleHeight = n / 2;
            int legsHeight = n / 2 + 1;

            string outerDots = new string('.', n);
            string middleDots = "";
            Console.WriteLine("{0}*{0}",outerDots);
            for (int i = 0; i < topMiddleHeight - 1; i++)
            {
                outerDots = new string('.', n - i - 1);
                middleDots = new string('.', i * 2 + 1);
                Console.WriteLine("{0}*{1}*{0}",outerDots,middleDots);
            }
            string asterisks = new string('*', n / 2 + 1);
            middleDots = new string('.', n - 1);
            Console.WriteLine("{0}{1}{0}",asterisks,middleDots);
            for (int i = 0; i < topMiddleHeight - 1; i++)
            {
                int outerDotsLength = i + 1;
                outerDots = new string('.', outerDotsLength);
                middleDots = new string('.', width - 2 * outerDotsLength - 2);
                Console.WriteLine("{0}*{1}*{0}",outerDots,middleDots);
            }
            outerDots = new string('.', n / 2);
            string legDots = new string('.', n / 2 - 1);
            Console.WriteLine("{0}*{1}*{1}*{0}",outerDots,legDots);
            for (int i = 0; i < legsHeight-2; i++)
            {
                outerDots = new string('.', n / 2 - i - 1);
                middleDots = new string('.', i * 2 + 1);
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}",outerDots,legDots,middleDots);
            }
            asterisks = new string('*', n / 2 + 1);
            middleDots = new string('.', n - 1);
            Console.WriteLine("{0}{1}{0}", asterisks, middleDots);
        }
    }
}
