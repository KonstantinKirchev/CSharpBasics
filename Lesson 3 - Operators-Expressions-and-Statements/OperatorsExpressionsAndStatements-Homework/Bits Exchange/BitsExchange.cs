using System;

    class BitsExchange
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            uint leftBits = (number >> 3) & 7;
            uint rightBits = (number >> 24) & 7;
            int leftMask = ~(7 << 3);
            int rightMask = ~(7 << 24);
            number &= (uint)leftMask;
            number &= (uint)rightMask;
            number |= rightBits << 3;
            number |= leftBits << 24;
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
         //   /* Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
         //* of given 32-bit unsigned integer
         //*/
         //   Console.Write("Enter unsigned integer n= ");
         //   uint n = uint.Parse(Console.ReadLine());

         //   // Take bits 3, 4, 5.
         //   uint bits345 = (n >> 3) & 7;

         //   // Set bits 3, 4, 5 to zeros.
         //   uint mask1 = ~((uint)7 << 3);
         //   uint result = n & mask1;

         //   // Take bits 24, 25, 26.
         //   uint bits242526 = (n >> 24) & 7;

         //   // Set bits 24, 25, 26 to zeros.
         //   uint mask2 = ~((uint)7 << 24);
         //   result = result & mask2;

         //   // Put bits 3, 4, 5 on the places 24, 25, 26.
         //   uint mask3 = bits345 << 24;
         //   result = result | mask3;

         //   // Put bits 24, 25, 26 on the places 3, 4, 5.
         //   uint mask4 = bits242526 << 3;
         //   result = result | mask4;

         //   Console.WriteLine("Result: " + result);
        }
    }

