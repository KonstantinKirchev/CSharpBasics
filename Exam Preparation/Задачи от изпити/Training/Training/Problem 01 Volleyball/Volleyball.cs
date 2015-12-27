using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        double weekendsPlays = 48 - hometown;
        weekendsPlays = weekendsPlays * 3d / 4d;
        double hometownPlays = hometown;
        double holidayPlays = holidays * 2d / 3d;

        double totalPlays = weekendsPlays + hometownPlays + holidayPlays;
        if (yearType == "leap")
        {
            totalPlays *= 1.15;
        }
        Console.WriteLine((int)totalPlays);
    }
}