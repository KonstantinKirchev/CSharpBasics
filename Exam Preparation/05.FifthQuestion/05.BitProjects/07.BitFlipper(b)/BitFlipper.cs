using System;

    class BitFlipper
    {
        static void Main()
        {
            ulong num = ulong.Parse(Console.ReadLine());
            for (int i = 61; i >= 0; i--)               
            {
                ulong threeBits = (num >> i) & 7; // измествам числото по 3 пъти и сравнявам всеки 3 бита дали са 0 или 7 
                if (threeBits==0 || threeBits==7)
                {
                    num ^= (ulong)7 << i; // ако са визам в if и ги обръщам. Нулите в единици и обратното.
                    i -= 2; // итератора го намалявам 2 пъти и горе още 1 път, съответно общо 3 пъти
                }
            }
            Console.WriteLine(num);
        }
    }

