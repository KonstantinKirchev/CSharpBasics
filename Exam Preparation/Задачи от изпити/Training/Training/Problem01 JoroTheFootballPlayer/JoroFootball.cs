using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        int weekendsTotal = 52;
        int weekends = weekendsTotal - hometown;
        double holidayPlays = holidays / 2d;
        double hometownPlays = hometown * 1d;
        double totalPlays = 0;

        if (yearType == "t")
        {
            totalPlays = weekends * 2d / 3d + holidayPlays + hometownPlays + 3;
        }
        else
        {
            totalPlays = weekends * 2d / 3d + holidayPlays + hometownPlays;
        }
        Console.WriteLine((int)totalPlays);

    }
}