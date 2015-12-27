using System;

    class WorkHours
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double workingHoursPerDay = 12;
            double workingDays = d * 0.9;
            double efficientWorkHours = workingDays * workingHoursPerDay * ((double)p / 100); // тук трябва да внимавам с кастванията!!!
            int ableToComplete = (int)efficientWorkHours - h; // и тук после закръглям надолу с int.
            if (ableToComplete>=0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(ableToComplete);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(ableToComplete);
            }
        }
    }

