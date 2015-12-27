using System;

class Electricity
{
    static void Main()
    {
        //electricity 
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.ParseExact(Console.ReadLine(), "H:m", null);

        double lamps = 100.53;
        double computers = 125.90;

        double result = 0;
        if(time.Hour >= 14 && time.Hour <= 18)
        {
            result = (floors * flats) * (2 * lamps + 2 * computers);
        }
        else if(time.Hour >= 19 && time.Hour <= 23)
        {
            result = (floors * flats) * (7 * lamps + 6 * computers);
        }
        else if(time.Hour >= 00 && time.Hour <= 8)
        {
            result = (floors * flats) * (1 * lamps + 8 * computers);
        }
        Console.WriteLine("{0} Watts",(int)result);
    }
}