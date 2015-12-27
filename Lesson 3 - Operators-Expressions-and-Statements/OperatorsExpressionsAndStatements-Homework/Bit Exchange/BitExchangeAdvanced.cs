using System;

    class BitExchangeAdvanced
    {
        static void Main()
        {
            //Console.Write("n= ");
            uint number = uint.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            //Console.Write("p= ");
            int p = int.Parse(Console.ReadLine()); // позицията на първия бит
            //Console.Write("q= ");
            int q = int.Parse(Console.ReadLine()); // позицията на втория бит
            //Console.Write("k= ");
            int k = int.Parse(Console.ReadLine()); // брой битове който да се разменят между 1ви и 2ри битове
            if (Math.Max(p, q) + k - 1 > 31) // Тук проверявам дали по-големият от двата бита + броя битове за смяна ще надхвърли 32 битовото число
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Min(p,q) + k - 1 >= Math.Max(p,q)) // Тук проверявам дали по-малкият от 2та бита + броя битове за смяна, ще застъпи по-големият
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;
                    uint leftBit = (number & (mask << q)) >> q; // Тук вземам левите битове и ги запазвам в променливата leftBit
                    uint rightBit = (number & (mask << i)) >> i; // Тук вземам десните битове и ги запазвам в променливата rightBit
                    number &= ~(mask << i); // Тук нулирам битовете на позиция p(защото i приема p -> виж горе в for цикъла)
                    number &= ~(mask << q); // Тук нулирам битовете на позиция q
                    number |= (leftBit << i); // Тук разменям битовете на вече нулираните позиции
                    number |= (rightBit << q); // Тук разменям битовете на вече нулираните позиции
                    q++; // това е нужно за да нараства q при всяка итерация на i(p)
               }
                Console.WriteLine(number);
                //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
                Main();
             //   /* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}
             //* of a given 32-bit unsigned integer. The first and the second sequence of bits
             //* may not overlap
             //*/
             //   Console.Write("Enter unsigned integer n= ");
             //   string input = Console.ReadLine();
             //   uint n;
             //   if (uint.TryParse(input, out n))
             //   {
             //       Console.Write("Enter start position for first sequence p= ");
             //       int p = int.Parse(Console.ReadLine());
             //       Console.Write("Enter start position for second sequence q= ");
             //       int q = int.Parse(Console.ReadLine());
             //       Console.Write("Enter the number of bits you want to exchange k= ");
             //       int k = int.Parse(Console.ReadLine());

             //       for (int i = p, j = q; i <= p + k - 1; i++, j++)
             //       {
             //           // Checking bits possition.
             //           uint mask1 = (uint)(1 << i);
             //           uint mask2 = (uint)(1 << j);
             //           uint bit1 = n & mask1;
             //           uint bit2 = n & mask2;

             //           // Bit of position {p, p+1, …, p+k-1) goes to bit of position {q, q+1, …, q+k-1}
             //           if (bit1 == 0)
             //           {
             //               uint calc = (uint)(1 << j);
             //               n = n & (~calc);
             //           }
             //           else
             //           {
             //               uint calc = (uint)(1 << j);
             //               n = n | calc;
             //           }

             //           // Bit of position {q, q+1, …, q+k-1} goes to bit of position {p, p+1, …, p+k-1}
             //           if (bit2 == 0)
             //           {
             //               uint calc = (uint)(1 << i);
             //               n = n & (~calc);
             //           }
             //           else
             //           {
             //               uint calc = (uint)(1 << i);
             //               n = n | calc;
             //           }
             //       }
             //       if (p - q >= k || q - p >= k)
             //       {
             //           Console.WriteLine("Result: " + n);
             //       }
             //       else
             //       {
             //           Console.WriteLine("overlapping");
             //       }
             //   }
             //   else
             //   {
             //       Console.WriteLine("out of range");
             //   } 
        }
    }

