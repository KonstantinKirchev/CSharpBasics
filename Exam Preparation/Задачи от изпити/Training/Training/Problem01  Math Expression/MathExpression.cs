using System;

class MathExpression
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double lower = n - (128.523123123 * p);
        double upper = (n * n) + (1 / (m * p)) + 1337;
        double last = Math.Sin((int)m % 180);
        double result = (upper / lower) + last;

        Console.WriteLine("{0:F6}", result);

    }
}

