using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d= ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e= ");
            double e = double.Parse(Console.ReadLine());
            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine("Biggest: " + a);
            }
                if (b >= a && b >= c && b >= d && b >= e)
                {
                    Console.WriteLine("Biggest: " + b);
                }
                    if (c >= b && c >= a && c >= d && c >= e)
                    {
                        Console.WriteLine("Biggest: " + c);
                    }
                        if (d >= b && d >= c && d >= a && d >= e)
                        {
                            Console.WriteLine("Biggest: " + d);
                        }
                            if (e >= a && e >= c && e >= d && e >= b)
                            {
                                Console.WriteLine("Biggest: " + e);
                            }
                            Console.WriteLine();
                            Main();
        }
    }

