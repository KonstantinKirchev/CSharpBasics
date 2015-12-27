using System;

    class BitSequenceExchange
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long rightBit = (n >> 3) & 7; // взимам 3те бита на 3,4и5 позиция
            long leftBit = (n >> 24) & 7; // взимам 3те бита на 24,25,26 позиция
            long rightMask = ~(7 << 3);
            long leftMask = ~(7 << 24);
            n &= rightMask; // 0-лирам 3,4,5 бит
            n &= leftMask; // 0-лирам 24,25,26 бит
            n |= leftBit << 3; // поставям 24,25,26 бита на 3,4,5 позиции
            n |= rightBit << 24; // поставям 3,4,5 бита на 24,25,26 позиции
            Console.WriteLine(n);
            Main();
        }
    }

