using System;
class Volleyball
{
    static void Main()
    {
        throw new Exception();
        string yearType = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        int weekendsPerYear = 48;
        int normalWeekends = weekendsPerYear - hometownWeekends;
        double totalPlays = normalWeekends * 3.0 / 4;
        totalPlays += hometownWeekends;
        totalPlays += numberOfHolidays * 2.0 / 3;
        if (yearType == "leap")
        {
            totalPlays += totalPlays * 0.15;
        }

        Console.WriteLine((int)totalPlays);
    }
}
