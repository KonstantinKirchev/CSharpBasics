using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int daysInARoll = int.Parse(Console.ReadLine());
        int watermelon = 0;
        int melon = 0;
        int countM = 0;
        int countW = 0;
        for (int currentDay = day, i = day; i < day + daysInARoll; currentDay++, i++) // тук е много важно да си направя два брояча един за дните който да влиза в switch, а друг за поредните дни който да върти for цикъла
        {
            if (currentDay % 8 == 0)
            {
                currentDay = 1;
            }
            switch (currentDay)
            {
                case 1:
                    watermelon = 1;
                    melon = 0;
                    break;
                case 2:
                    watermelon = 0;
                    melon = 2;
                    break;
                case 3:
                    watermelon = 1;
                    melon = 1;
                    break;
                case 4:
                    watermelon = 2;
                    melon = 0;
                    break;
                case 5:
                    watermelon = 2;
                    melon = 2;
                    break;
                case 6:
                    watermelon = 1;
                    melon = 2;
                    break;
                case 7:
                    watermelon = 0;
                    melon = 0;
                    break;
            }
            countM += melon;
            countW += watermelon;
        }

        if (countM == countW)
        {
            Console.WriteLine("Equal amount: {0} ", countW);
        }
        else if (countW > countM)
        {
            Console.WriteLine("{0} more watermelons", countW - countM);
        }
        else if (countW < countM)
        {
            Console.WriteLine("{0} more melons", countM - countW);
        }
    }
}

