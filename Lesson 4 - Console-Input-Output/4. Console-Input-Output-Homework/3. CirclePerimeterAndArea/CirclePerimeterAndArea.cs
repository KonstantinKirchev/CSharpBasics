using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("r= ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("perimeter of a circle = {0:0.00}\narea of a circle = {1:F2}", perimeter, area);
            Main();
        }
    }

