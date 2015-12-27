using System;

    class MagicDates
    {
        static void Main()
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            bool isTrue = false; // Тази булева променлива е задължителна, за да ми върне два резултата(стойност или "No")
            DateTime startDate = new DateTime(startYear,1,1);
            DateTime endDate = new DateTime(endYear,12,31);
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                string number = "" + i.Day; // По този начин си взимам всички числа от датата, долепям ги едно до друго и ги превръщам в стринг
                number += i.Month; // същото правя за месеца
                number += i.Year; // и годината
                int sum = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    int currentDigit = int.Parse(number[j].ToString()); // По този начин взимам числата от стринга и ги превръщам в интове.
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        int digitToMultiply = int.Parse(number[k].ToString()); // Тук вземам следващото число от стринга
                        sum += currentDigit * digitToMultiply;
                    }
                }
                if (sum==weight)
                {
                    Console.WriteLine("{0:00}-{1:00}-{2}",i.Day,i.Month,i.Year);
                    isTrue = true;
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }

