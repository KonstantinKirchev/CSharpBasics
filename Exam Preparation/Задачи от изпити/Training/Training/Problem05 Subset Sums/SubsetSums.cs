using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSums
{
    static void Main()
    {
        
        decimal targetSum = decimal.Parse(Console.ReadLine());
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

        }

        int counter = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(targetSum == numbers[i] + numbers[i+1])
            {
                counter++;
            }

        }
        Console.WriteLine(counter);


    }

    //static void findNumbers(int[] list, int index, int current, int goal, string result)
    //{
    //    if (list.Length < index || current > goal)
    //        return;
    //    for (int i = index; i < list.Length; i++)
    //    {
    //        if (current + list[i] == goal)
    //        {
    //            Console.WriteLine(result + " " + list[i].ToString());
    //        }
    //        else if (current + list[i] < goal)
    //        {
    //            findNumbers(list, i + 1, current + list[i], goal, result + " " + list[i].ToString());
    //        }
    //    }
    //}

}

