using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? number = null;
            double? doubleNumber = null;
            Console.WriteLine(number);
            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(doubleNumber);          
            Console.WriteLine(doubleNumber.GetValueOrDefault());
        }
    }

