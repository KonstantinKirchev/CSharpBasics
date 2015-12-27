using System;

    class PointInsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            Console.Write("Please enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5,2) && y > 1;
            bool isInRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
            if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("Inside K & outside of R: yes");
            }
            else
            {
                Console.WriteLine("Inside K & outside of R: no");
            }
            Console.WriteLine();
            Main();
        }
    }

