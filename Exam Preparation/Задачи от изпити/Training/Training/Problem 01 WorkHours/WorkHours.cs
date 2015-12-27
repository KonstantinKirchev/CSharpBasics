using System;

class WorkHours
{
    static void Main()
    {
        int deadlineHours = int.Parse(Console.ReadLine());
        int deadlineDays = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());

        decimal productivityPercent = (decimal)productivity / 100;
        double hoursToComplete = ((deadlineDays - (deadlineDays * 0.10)) * 12) * (double)productivityPercent;

        if (deadlineHours > hoursToComplete)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}{1}", '-', deadlineHours - (int)hoursToComplete);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}", (int)hoursToComplete - deadlineHours);
        }
    }
}