using System;

class Disk
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int diskCenterRow = fieldSize / 2, // така намираме центъра на диска спрямо реда
            diskCenterCol = fieldSize / 2; // така намираме центъра на диска спрямо колоната

        for (int currentRow = 0; currentRow < fieldSize; currentRow++) // този цикъл ми върти редовете
        {
            for (int currentCol = 0; currentCol < fieldSize; currentCol++) // този цикъл ми върти колоните
            {
                int deltaX = currentCol - diskCenterCol, // така намирам къде е точката по X
                    deltaY = currentRow - diskCenterRow; // така намирам къде е точката по Y
                double distanceToCenter = Math.Sqrt(deltaX * deltaX + deltaY * deltaY); // така намирам на какво разстояние е точката с координати XY от центъра на диска.
                bool isWithinDisk = distanceToCenter <= radius; // с тази променлива проверявам дали точката е вътре в диска

                if (isWithinDisk) // ако е вътре отпечатва звезда
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.'); // ако не е отпечатва точка
                }
            }
            Console.WriteLine();
        }
    }
}
