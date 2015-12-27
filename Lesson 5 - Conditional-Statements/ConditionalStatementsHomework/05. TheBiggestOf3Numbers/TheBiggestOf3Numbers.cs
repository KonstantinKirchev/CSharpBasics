using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {

            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            if (Math.Max(a,b)>=c)
            {
                Console.WriteLine("Biggest: " + Math.Max(a, b));
            }
            else
            {
                Console.WriteLine("Biggest: " + c);
            }
            Main();
        }
    }
    

