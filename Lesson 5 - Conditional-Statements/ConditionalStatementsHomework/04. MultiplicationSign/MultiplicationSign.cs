using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            if (a * b * c == 0)
            {
                Console.WriteLine("Result: 0");
            }
                if (a * b * c > 0)
                {
                    Console.WriteLine("Result: +");
                }
                    if (a * b * c < 0)
                    {
                        Console.WriteLine("Result: -");
                    }
                    Console.WriteLine();
            Main();
        }
    }

