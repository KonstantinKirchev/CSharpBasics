using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string[] numbersAsStrings = Console.ReadLine().Split();
            int jumps = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersAsStrings.Length];
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }


            int maxSum = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int index = i;
                int currentSum = numbers[index];
                for (int j = 0; j < jumps; j++)
                {
                    index = (index + numbers[index]) % numbers.Length;
                    currentSum += numbers[index];
                }
                maxSum = Math.Max(maxSum, currentSum);
            }
            Console.WriteLine("max sum = {0}",maxSum);
        }
    }
}
