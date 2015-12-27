using System;

    class OddEvenSum
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine()); // каунта ми е отделно за четните и нечетните
            int[] number = new int[count*2]; // затова тук си пълня масив с каунт * 2, защото вкарвам всички числа(четни и нечетни)
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < count * 2; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < count*2; i+=2)
            {
                sumOdd += number[i]; // сумирам всички нечетни
            }
            for (int i = 1; i < count*2; i+=2)
            {
                sumEven += number[i]; // сумирам всички четни
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes, sum={0}",sumOdd);
            }
            if (sumEven != sumOdd)
            {
                Console.WriteLine("No, diff={0}", Math.Max(sumEven, sumOdd) - Math.Min(sumEven, sumOdd));
            }
        }
    }

