using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("a= ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("greater= " + (firstNumber>secondNumber? firstNumber:secondNumber));
            Main();
        }
    }

