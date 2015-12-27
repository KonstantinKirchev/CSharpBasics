using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int[] values = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };

        int[] allValues = new int[values.Length * values.Length];
        int index = 0;
        for (int i = 0; i < values.Length; i++)
        {
            for (int c = 0; c < values.Length; c++)
            {
                allValues[index] = values[i] + values[c] + 40;
                index++;
            }
        }
        int count = 0;
        for (int i = 0; i < allValues.Length; i++)
        {
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    if (a == b)
                    {
                        if (allValues[i] + a * 4 == input) ++count;
                    }
                    else
                    {
                        if (allValues[i] + a + 3 * b == input) ++count;
                        if (allValues[i] + 3 * a + b == input) ++count;
                        if (allValues[i] + 2 * a + 2 * b == input) count += 3;
                    }
                }
            }
        }
        Console.WriteLine(count);
        //int magicWeight = int.Parse(Console.ReadLine());
        //int[] letters = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        //int[] value = new int[letters.Length * letters.Length];
        //int index = 0;
        //int counter = 0;
        //for (int i = 0; i < value.Length; i++)
        //{
        //    for (int j = 0; j < value.Length; j++)
        //    {
        //        value[index] = letters[i] + letters[j] + 40;
        //        index++;
        //    }
        //}
        //for (int i = 0; i < value.Length; i++)
        //{
        //    for (int a = 0; a < 10; a++)
        //    {
        //        for (int b = 0; b < 10; b++)
        //        {
        //            if (a==b)
        //            {

        //                if (value[i] + a * 4 == magicWeight)
        //                {
        //                    counter++;
        //                }
        //                else
        //                {
        //                    if (value[i] + a + 3 * b == magicWeight) ++counter;
        //                    if (value[i] + a * 3 + b == magicWeight) ++counter;
        //                    if (value[i] + a * 2 + 2 * b == magicWeight) counter+=3;

        //                }
        //            }
        //        }
        //    }
        //}
        //Console.WriteLine(counter);
    }
}

