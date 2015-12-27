using System;

    class SumOfnNumbers
    {
        static void Main()
        {
            Console.Write("Counter=");
            int counter = int.Parse(Console.ReadLine());
            double sum = 0;
            Console.WriteLine("numbers");
            for (int i = 0; i < counter; i++)
            {               
                double number = double.Parse(Console.ReadLine());
                sum +=number;
            }
            Console.WriteLine("sum="+sum);
            Main();
        }
    }

