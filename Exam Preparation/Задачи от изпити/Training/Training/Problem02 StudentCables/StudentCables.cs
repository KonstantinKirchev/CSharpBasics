using System;

class StudentCables
{

    static void Main()
    {
        int cablesCount = int.Parse(Console.ReadLine());
        int invalidCables = 0;
        int sum = 0;
        for (int i = 0; i < cablesCount; i++)
        {
            int value = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (value < 20 && measure == "centimeters")
            {
                invalidCables++;
                continue;
            }
            else if (measure == "meters")
            {
                sum += value * 100;
            }
            else
            {
                sum += value;
            }
        }
        sum -= 3 * (cablesCount - invalidCables - 1);
        int result = sum / 504;
        int remainder = sum % 504;
        Console.WriteLine(result);
        Console.WriteLine(remainder);
    }
}