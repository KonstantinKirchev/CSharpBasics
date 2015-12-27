using System;
class Program
{
    static void Main()
    {
        int startDay = int.Parse(Console.ReadLine());
        int eatingDays = int.Parse(Console.ReadLine());
        int waterMelon = 0, melon = 0;

        for (int i = 0; i < eatingDays; i++)
        {
            if (startDay == 1)
            {
                waterMelon += 1;
            }
            else if (startDay == 2)
            {
                melon += 2;
            }
            else if (startDay == 3)
            {
                waterMelon += 1;
                melon += 1;
            }
            else if (startDay == 4)
            {
                waterMelon += 2;
            }
            else if (startDay == 5)
            {
                waterMelon += 2;
                melon += 2;
            }
            else if (startDay == 6)
            {
                waterMelon += 1;
                melon += 2;
            }

            if (startDay == 7)
            {
                startDay = 1;
            }
            else
            {
                startDay++;
            }
        }

        if (waterMelon > melon)
        {
            waterMelon -= melon;
            Console.WriteLine("{0} more watermelons", waterMelon);
        }
        else if (melon > waterMelon)
        {
            melon -= waterMelon;
            Console.WriteLine("{0} more melons", melon);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melon);
        }
    }
}