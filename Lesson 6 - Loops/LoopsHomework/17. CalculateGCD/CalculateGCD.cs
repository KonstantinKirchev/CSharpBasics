using System;

    class CalculateGCD
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int remain = a % b;
            while (remain != 0)
            {
                a = b;
                b = remain;
                remain = a % b;
            }
            Console.WriteLine(Math.Abs(b));
            Main();

        }
    }

