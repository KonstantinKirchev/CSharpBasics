using System;

    class JoroTheFootballPlayer
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double numberOfHolidays = double.Parse(Console.ReadLine());
            double weekendsHometown = double.Parse(Console.ReadLine());
            double weekend = 0;
            double holiday = 0;
            double totalN = 0;
            int totalL = 0;
            if (year == "f")
            {
                weekend = ((52 - weekendsHometown) * 2 / 3) + weekendsHometown;
                holiday = (double)(numberOfHolidays * 1 / 2); // трябва да следа какво се иска.Ако искат със запетая трябва да каствам към double.
                totalN = (int)(weekend + holiday); // после закръглям надолу, като каствам към int.
                Console.WriteLine(totalN);
            }
            else if (year == "t")
            {
                weekend = ((52 - weekendsHometown) * 2 / 3) + weekendsHometown;
                holiday = (double)(numberOfHolidays * 1 / 2);
                totalN = weekend + holiday;
                totalL = (int)(3 + totalN);
                Console.WriteLine(totalL);
            }
        }
    }

