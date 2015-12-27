using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Please enter base a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter base b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter height h = ");
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;
            Console.WriteLine("The area of the trapezoid is = " + area);
            Console.WriteLine();
            Main();
        }
    }

