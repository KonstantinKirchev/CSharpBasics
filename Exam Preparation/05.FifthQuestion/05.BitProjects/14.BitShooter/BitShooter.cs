using System;
using System.Linq;

class BitShooter
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string[] firstShot = Console.ReadLine().Split(); 
        string[] secondShot = Console.ReadLine().Split();
        string[] thirdShot = Console.ReadLine().Split();
        int firstCenter = int.Parse(firstShot[0]); // център на изтрела
        int firstSize = int.Parse(firstShot[1]); // обхват на изтрела
        int secondCenter = int.Parse(secondShot[0]);
        int secondSize = int.Parse(secondShot[1]);
        int thirdCenter = int.Parse(thirdShot[0]);
        int thirdSize = int.Parse(thirdShot[1]);

        int rightCount = 0;
        int leftCount = 0;

        TakeTheShot(ref number, firstCenter, firstSize); // тук си викам метода и той нулира всички битове в обсега на изтрела
        TakeTheShot(ref number, secondCenter, secondSize);
        TakeTheShot(ref number, thirdCenter, thirdSize);

        for (int i = 0; i < 32; i++)
        {
            if ((number & 1) == 1) // проверявам 0левия бит
            {
                rightCount++; // така преброявам останалите 1ци след края на изстрелите
            }
            number = number >> 1; // след това премествам на следващия бит, за да го проверя дали е 0 или 1
        }
        while (number > 0) // така ги прекарвам от 32 до 64 бит и отброявам 1ците.
        {
            if ((number & 1) == 1)
            {
                leftCount++;
            }
            number = number >> 1;
        }
        Console.WriteLine("left: {0}", leftCount);
        Console.WriteLine("right: {0}", rightCount);
    }
    private static void TakeTheShot(ref ulong number, int center, int size)
    {
        int rightmostBit = Math.Max(center - size / 2, 0);//Така проверявам дали обсегът на изтрела излиза извън 64 битовото число и ако излиза приемам най-десният бит за 0 
        int leftmostBit = Math.Min(center + size / 2, 63);//Така проверявам дали обсегът на изтрела излиза извън 64 битовото число и ако излиза приемам най-левият бит за 63


        for (int index = rightmostBit; index <= leftmostBit; index++)
        {
            ulong one = 1u;
            ulong mask = ~(one << index);
            number = number & mask;
        }

    }
}

