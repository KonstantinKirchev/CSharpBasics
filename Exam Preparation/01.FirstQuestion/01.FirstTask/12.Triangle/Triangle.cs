using System;

    class Triangle
    {
        static void Main()
        {
            int aX = int.Parse(Console.ReadLine()); // При тази задача всички формули са дадени в условието.Просто следвам условието!!!
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());
            double ab = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2)); // D = Math.Sqrt(x2-x1)^2 + (y2-y1)^2
            double ac = Math.Sqrt(Math.Pow((cX - aX), 2) + Math.Pow((cY - aY), 2));
            double bc = Math.Sqrt(Math.Pow((cX - bX), 2) + Math.Pow((cY - bY), 2));
            if (ab + ac > bc && ac + bc > ab && ab + bc > ac) // a+b>c; b+c>a; a+c>b;
            {
                Console.WriteLine("Yes");
                double p = (ab + ac + bc) / 2; // p = (a+b+c)/2
                double area = Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc)); // area = Math.Sqrt(p*(p-a)*(p-b)*(p-c))
                Console.WriteLine("{0:F2}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}",ab);
            }
        }
    }

