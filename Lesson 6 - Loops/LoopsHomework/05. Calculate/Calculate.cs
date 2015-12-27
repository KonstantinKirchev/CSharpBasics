using System;

    class Calculate
    {
        static void Main()
        {
        
            int number = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double multiplicateX = 1;
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                multiplicateX *= x;
                result += factorial / multiplicateX;
            }
                Console.WriteLine("{0:F5}", result);
            Main();
        }
    }

