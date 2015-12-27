using System;

    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("a= ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double tirdthNumber = double.Parse(Console.ReadLine());
            double sum = firstNumber + secondNumber + tirdthNumber;
            Console.WriteLine("sum= {0}",sum);
            Main();
        }
    }
