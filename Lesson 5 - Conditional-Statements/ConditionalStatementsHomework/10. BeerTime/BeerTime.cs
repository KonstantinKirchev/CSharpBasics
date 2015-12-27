using System;

    class BeerTime
    {
        static void Main()
        {
            string[] timeArray = Console.ReadLine().Split(':',' ');
            int hour = Convert.ToInt32(timeArray[0]);
            int minute = Convert.ToInt32(timeArray[1]);
            string ampm = timeArray[2];
            if ((hour>=1 && ampm == "PM") || (hour<3 && ampm == "AM"))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
            Main();
        }           
    }

