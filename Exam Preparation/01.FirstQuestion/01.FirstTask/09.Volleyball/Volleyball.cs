using System;

    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double weekend = 0;
            double holiday = 0;
            double totalN = 0;
            int totalL = 0;
            if (year == "normal")
            {
                weekend = ((48 - w) * 3 / 4) + w;
                holiday = (double)(h * 2 / 3); // трябва да следа какво се иска.Ако искат със запетая трябва да каствам към double.
                totalN = (int)(weekend + holiday); // после закръглям надолу, като каствам към int.
                Console.WriteLine(totalN);
            }
            else if (year == "leap")
            {
                weekend = ((48 - w) * 3 / 4) + w;
                holiday = (double)(h * 2 / 3);
                totalN = weekend + holiday;
                totalL = (int)((totalN * 15 / 100) + totalN);
                Console.WriteLine(totalL);
            }
        }
    }