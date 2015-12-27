using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string number = Convert.ToString(numbers, 10);
            int[] num = new int[number.Length];
            BigInteger maxMax = 0;
            
            for (int i = 0; i < number.Length; i+=6)
            {
                num[i] = 
                int maxSum = num.Skip(i).Take(6).Sum();
                if (maxSum > maxMax)
                {
                    maxMax = maxSum;                
                }
            }
            Console.WriteLine(maxMax);




        //    string[] letters = { "A", "P", "K", "L", "Z" };
        //    for (int i = 0; i < letters.Length; i++)
        //    {
        //        for (int j = 0; j < letters.Length; j++)
        //        {
        //            if (letters[j]==letters[i])
        //            {
        //                continue;
        //            }
        //            for (int k = 0; k < letters.Length; k++)
        //            {
        //                if (letters[k]==letters[j] || letters[k]==letters[i] || letters[j]==letters[i])
        //                {
        //                    continue;
        //                }
        //                for (int h = 0; h < letters.Length; h++)
        //                {
        //                    if (letters[k]==letters[j] || letters[k]==letters[i] || letters[j]==letters[i] || letters[h]==letters[j] || letters[h]==letters[i] || letters[h]==letters[k])
        //                    {
        //                        continue;
        //                    }
        //                    for (int g = 0; g < letters.Length; g++)
        //                    {
        //                        if (letters[k]==letters[j] || letters[k]==letters[i] || letters[j]==letters[i] || letters[h]==letters[j] || letters[h]==letters[i] || letters[h]==letters[k] || letters[h]==letters[g] || letters[g]==letters[i] || letters[g]==letters[k] || letters[g]==letters[j])
        //                        {
        //                            continue;
        //                        }
        //                        Console.WriteLine("{0} {1} {2} {3} {4}", letters[i], letters[j], letters[k], letters[h], letters[g]);
        //                    }
        //                }
        //            }
        //        }
        //    }
        }
    }
}
