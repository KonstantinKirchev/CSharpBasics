using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Your number can be devided by 7 and 5 in the same time: ");
            bool divisible = number % 5 == 0 && number % 7 == 0;
            Console.WriteLine(divisible);
            Main();    
        }
    }

