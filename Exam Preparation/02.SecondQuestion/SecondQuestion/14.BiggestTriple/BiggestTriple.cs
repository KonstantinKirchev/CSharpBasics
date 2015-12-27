using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse); // така си вземам числата от стринг масива
        //int[] numbers = input.Select(int.Parse).ToArray(); // така също мога да си взема числата от стринг масива
        //int[] numbers = new int[input.Length]; // 3ти вариант за вземане на числата от стринг масива
        //for (int i = 0; i < input.Length; i++)
        //{
        //    numbers[i] = int.Parse(input[i]);                    
        //}         
        int maxMax = Int32.MinValue;
        //List<int> three = new List<int>();
        int[] three = new int[3];
        for (int i = 0; i < numbers.Length; i += 3)
        {
            int maxSum = numbers.Skip(i).Take(3).Sum();

            if (maxSum > maxMax)
            {
                maxMax = maxSum;
                three = numbers.Skip(i).Take(3).ToArray();
            }
        }
        foreach (var number in three)
        {
            Console.Write(number + " ");
        }
        //three.ForEach(x => Console.Write(x + " "));

        //string inputLine = Console.ReadLine();
        //string[] numbers = inputLine.Split(' ');
        //int index = 0;
        //int maxSum = Int32.MinValue;
        //int start = 0;
        //while (index < numbers.Length)
        //{
        //    int num1 = int.Parse(numbers[index]);
        //    int num2 = 0;
        //    if (index + 1 < numbers.Length)
        //    {
        //        num2 = int.Parse(numbers[index + 1]);
        //    }
        //    int num3 = 0;
        //    if (index + 2 < numbers.Length)
        //    {
        //        num3 = int.Parse(numbers[index + 2]);
        //    }
        //    int sum = num1 + num2 + num3;
        //    if (sum > maxSum)
        //    {
        //        maxSum = sum;
        //        start = index;
        //    }
        //    index = index + 3;
        //}

        //// Print the result
        //while (maxSum != 0)
        //{
        //    Console.Write(numbers[start]);
        //    maxSum = maxSum - int.Parse(numbers[start]);
        //    start++;
        //    if (maxSum != 0)
        //    {
        //        Console.Write(" ");
        //    }
        //}
    }
}

