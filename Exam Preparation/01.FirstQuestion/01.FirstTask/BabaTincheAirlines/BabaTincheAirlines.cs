using System;

    class BabaTincheAirlines
    {
        static void Main()
        {
            string[] firstClass = Console.ReadLine().Split();
            int passengersF = int.Parse(firstClass[0]);
            int frequentFliersF = int.Parse(firstClass[1]);
            int perchaseMealF = int.Parse(firstClass[2]);

            string[] businessClass = Console.ReadLine().Split();
            int passengersB = int.Parse(businessClass[0]);
            int frequentFliersB = int.Parse(businessClass[1]);
            int perchaseMealB = int.Parse(businessClass[2]);

            string[] economyClass = Console.ReadLine().Split();
            int passengersE = int.Parse(economyClass[0]);
            int frequentFliersE = int.Parse(economyClass[1]);
            int perchaseMealE = int.Parse(economyClass[2]);

            int income = ((passengersF - frequentFliersF) * 7000 + frequentFliersF * 7000 * 30 / 100 + perchaseMealF * 7000 * 5 / 1000)
                       + ((passengersB - frequentFliersB) * 3500 + frequentFliersB * 3500 * 30 / 100 + perchaseMealB * 3500 * 5 / 1000)
                       + ((passengersE - frequentFliersE) * 1000 + frequentFliersE * 1000 * 30 / 100 + perchaseMealE * 1000 * 5 / 1000);
            int maxIncome = (12 * 7000 + 12 * 7000 * 5 / 1000)
                          + (28 * 3500 + 28 * 3500 * 5 / 1000)
                          + (50 * 1000 + 50 * 1000 * 5 / 1000);
            int difference = maxIncome - income;
            Console.WriteLine(income);
            Console.WriteLine(difference);
        }
    }

