using System;

    class FibonacciNumbers
    {
        public static double Fibonacci(int n)
        {
            double a = 0;
            double b = 1;
           
            for (int i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0} ",Fibonacci(i));
            }
            Console.WriteLine();
            Main();
        }
    }

