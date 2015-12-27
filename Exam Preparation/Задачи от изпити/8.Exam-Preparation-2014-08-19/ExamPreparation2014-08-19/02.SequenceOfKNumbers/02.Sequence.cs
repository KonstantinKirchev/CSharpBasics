using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SequenceOfKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool print = false;
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string[] numbers = input.Split(new char[] {' '},
                StringSplitOptions.RemoveEmptyEntries);
            int numberOfElements = 0;
            string lastNumber = numbers[0];
            int count = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (lastNumber == numbers[i])
                {
                    count++;
                }
                else
                {
                    numberOfElements = count;
                    if (count >= k)
                    {
                        numberOfElements = count % k;
                    }
                    
                    for (int j = 0; j < numberOfElements; j++)
                    {
                        Console.Write(" " + lastNumber);
                    }

                    count = 1;  
                }

                lastNumber = numbers[i];
            }

            numberOfElements = count;
            if (count >= k)
            {
                numberOfElements = count % k;
            }

            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write(" " + lastNumber);
            }

        }
    }
}
