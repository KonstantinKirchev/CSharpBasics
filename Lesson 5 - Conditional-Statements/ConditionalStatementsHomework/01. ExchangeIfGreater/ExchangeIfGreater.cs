using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? "result: "+ b + " " + a : "result: " + a + " " + b);
            Main();
        }
    }

