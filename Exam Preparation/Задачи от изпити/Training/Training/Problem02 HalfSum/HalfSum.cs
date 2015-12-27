using System;

class HalfSum
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int size = input * 2;
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sumFirst = 0;
        for (int i = 0; i < input; i++)
        {
            sumFirst += numbers[i];
        }

        int sumSecond = 0;
        for (int i = input; i < size; i++)
        {
            sumSecond += numbers[i];
        }

        if (sumFirst == sumSecond)
        {
            Console.WriteLine("Yes, sum={0}", sumFirst);
        }
        else
        {
            int difference = Math.Abs(sumFirst - sumSecond);
            Console.WriteLine("No, diff={0}", difference);
        }
    }
}