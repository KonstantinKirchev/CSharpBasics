using System;

    class Electricity
    {
        static void Main()
        {
            
            uint numberOfFloors = uint.Parse(Console.ReadLine());
            uint numberOfFlatsOnFloor = uint.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine()); // използвам класа DateTime за да си прочета часа и минутите от конзолата
            double consumption = 0;
            if (time.Hour >= 14 && time.Hour <= 18) // чрез time.Hour взимам само часа и манипулирам с него
            {
                consumption = (2 * 100.53 + 2 * 125.90) * numberOfFloors * numberOfFlatsOnFloor;
                Console.WriteLine("{0} Watts",(int)consumption);
            }
            else if (time.Hour >= 19 && time.Hour <= 23)
            {
                consumption = (7 * 100.53 + 6 * 125.90) * numberOfFloors * numberOfFlatsOnFloor;
                Console.WriteLine("{0} Watts", (int)consumption);
            }
            else if (time.Hour >= 0 && time.Hour <= 8)
            {
                consumption = (1 * 100.53 + 8 * 125.90) * numberOfFloors * numberOfFlatsOnFloor;
                Console.WriteLine("{0} Watts", (int)consumption);
            }
            else
            {
                consumption = 0;
                Console.WriteLine("{0} Watts",consumption);
            }
        }
    }

