using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            double counter = double.Parse(Console.ReadLine());
            double sum = 0;
            double avg = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < counter; i++)
            {
                //Console.Write("number{0}= ",i+1);
                double number = double.Parse(Console.ReadLine());   
                sum += number;
                avg = sum / counter;
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine("min= " + min);
            Console.WriteLine("max= " + max);
            Console.WriteLine("sum= " + sum);
            Console.WriteLine("avg= {0:F2}",avg);
            Main();
        }
    }

