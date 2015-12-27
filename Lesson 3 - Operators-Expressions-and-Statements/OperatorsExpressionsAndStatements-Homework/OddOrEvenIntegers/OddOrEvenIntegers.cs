using System;

    class  OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Is this number odd: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool oddNumber = (number % 2 != 0);
            Console.WriteLine(oddNumber);
            Main();
        }
    }
