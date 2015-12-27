using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + height * 2;
            double area = width * height;
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.WriteLine();
            Main();
        }
    }

