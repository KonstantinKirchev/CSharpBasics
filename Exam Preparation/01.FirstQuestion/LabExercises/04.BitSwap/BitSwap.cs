using System;

    class BitSwap
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long rightBit = (n >> 3) & 1; // взимам бита на 3та позиция
            long leftBit = (n >> 24) & 1; // взимам бита на 24та позиция
            long rightMask = ~(1 << 3);  
            long leftMask = ~(1 << 24); 
            n &= rightMask; // 0-лирам 3тия бит
            n &= leftMask; // 0-лирам 24тия бит
            n |= leftBit << 3; // поставям 24тия бит на 3та позиция
            n |= rightBit << 24; // поставям 3тия бит на 24та позиция
            Console.WriteLine(n);
        }
    }

