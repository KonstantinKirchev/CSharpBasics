using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("n= ");
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;
            Console.WriteLine((mask << 3 & number) == 0 ? "0" : "1");
            Main();
        }
    }

