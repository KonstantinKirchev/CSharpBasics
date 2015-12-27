using System;

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("n= ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("p= ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1;
            Console.WriteLine((mask << position & number) != 0 ? true : false);
            Main();
        }
    }

