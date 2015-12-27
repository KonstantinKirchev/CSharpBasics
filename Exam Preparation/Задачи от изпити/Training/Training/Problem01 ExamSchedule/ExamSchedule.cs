using System;
using System.Globalization;

class ExamSchedule
{
    static void Main()
    {
        string startHour = Console.ReadLine();
        string startMinute = Console.ReadLine();
        string timeOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        int minutes = (durationHours * 60) + durationMinutes;
        string temp = startHour + ":" + startMinute + " " + timeOfDay;
        DateTime start = DateTime.ParseExact(temp, "h:m tt", CultureInfo.InvariantCulture);
        DateTime result = start.AddMinutes(minutes);
        string finalResult = result.ToString("hh:mm:tt");
        Console.WriteLine(finalResult);
    }
}