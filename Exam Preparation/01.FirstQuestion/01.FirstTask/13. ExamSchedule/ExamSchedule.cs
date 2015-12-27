using System;
using System.Globalization;
using System.Threading;

class ExamSchedule
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");

        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        if (partOfDay == "PM")
        {
            startHour += 12; // ако е PM добавям 12 часа, защото обръщането ще стане при 24 часа, а не при 12 !!!

            if (startHour == 24)
            {
                startHour = 0; // ако часа е 24 го нулирам
            }
        }

        DateTime startTime = new DateTime(2014, 12, 05, startHour, startMinutes, 0); // тук си правя new DateTime който да ми пази зададените час и минути
        DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes); // тук добавям часовете и минутите. Тук става обръщането от АМ в PM и обратно.
        Console.WriteLine("{0:hh:mm:tt}", endTime); // тук си форматирам изхода


        //int startHour = int.Parse(Console.ReadLine());
        //int startMinutes = int.Parse(Console.ReadLine());
        //string ampm = Console.ReadLine();
        //int durationHour = int.Parse(Console.ReadLine());
        //int durationMinutes = int.Parse(Console.ReadLine());
        //int endHour = startHour + durationHour;
        //int endMinute = startMinutes + durationMinutes;
        //while (endMinute >= 60)
        //{
        //    endHour++;
        //    endMinute -= 60;
        //}
        //if (endHour >= 12)
        //{
        //    int changePartOfDay = 0;
        //while (endHour>=12)
        //{
        //    endHour -= 12;
        //    changePartOfDay++;
        //}           
        //    if (endHour == 0)
        //    {
        //        endHour += 12;
        //    }
        //    if (changePartOfDay % 2 != 0)
        //    {
        //        if (ampm == "AM")
        //        {
        //            ampm = "PM";
        //        }
        //        else
        //        {
        //            ampm = "AM";
        //        }
        //    }
        //}
        //Console.WriteLine(endHour.ToString().PadLeft(2,'0')
        //                +':'+ endMinute.ToString().PadLeft(2,'0') + ':' + ampm);
    }
}
