using System;

    class BitCopy
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            int bit = (n >> p) & 1;
            if (bit == 0)
            {
                int mask = 1;
                int result = n & ~(mask << 2);
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1;
                int result = n | (mask << 2);
                Console.WriteLine(result);
            }
            Console.WriteLine();
            Main();
        }
    }

