using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            double sqrtpart = Math.Pow(b,2) - 4 * a * c;
            double x1, x2;
            x1 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            if (sqrtpart > 0)
            {           
                Console.WriteLine("x1={0} x2={1}", x1, x2);            
            }
            if (sqrtpart == 0)
            {
                 if (x1==x2)
                {
                    Console.WriteLine("x1=x2={0}", x2);
                }
            }
            if (sqrtpart < 0)
            {
                Console.WriteLine("no real roots");
            }
            
            Main();
        }
    }

