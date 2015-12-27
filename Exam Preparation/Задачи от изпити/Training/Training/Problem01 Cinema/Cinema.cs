using System;

class Program
{
    static void Main()
    {
        //Problem01 Cinema
        string input = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int cinemaSize = rows * cols;
        double income = 0;
        if (input == "Premiere")
        {
            income = cinemaSize * 12.00;
        }
        else if (input == "Normal")
        {
            income = cinemaSize * 7.50;
        }
        else // Discount
        {
            income = cinemaSize * 5.00;
        }
        Console.WriteLine("{0:F2} leva", income);
    }
}