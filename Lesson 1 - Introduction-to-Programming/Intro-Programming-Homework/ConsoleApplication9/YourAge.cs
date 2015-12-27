using System;

    class YourAge
    {
        static void Main()
        {
            Console.Write("Enter your year of birth: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter your month of birth: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter your day of birth: ");
            int day = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            int ageInYears = 0;
            int ageInMonths = 0;
            int ageInDays = 0;

            ageInDays = currentDate.Day - dateOfBirth.Day;
            ageInMonths = currentDate.Month - dateOfBirth.Month;
            ageInYears = currentDate.Year - dateOfBirth.Year;

            if (ageInDays < 0)
            {
                ageInDays += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                ageInMonths = ageInMonths--;
            }
                if (ageInMonths < 0)
                {
                    ageInMonths += 12;
                    ageInYears--;
                }
                Console.WriteLine();
                Console.Write("This is your current age : ");
                Console.WriteLine("{0}years {1}months and {2}days", ageInYears, ageInMonths, ageInDays);
                Console.WriteLine("This will be your age in 10 years: {0}years {1}months and {2}days", ageInYears + 10, ageInMonths, ageInDays + 3);
                Console.WriteLine();
                Main();
        }
    }

