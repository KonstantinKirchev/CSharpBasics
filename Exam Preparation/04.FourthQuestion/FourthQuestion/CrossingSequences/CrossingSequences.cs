using System;

    class CrossingSequences
    {
        static void Main()
        {
            int trib1 = int.Parse(Console.ReadLine());
            int trib2 = int.Parse(Console.ReadLine());
            int trib3 = int.Parse(Console.ReadLine());
            int initialNumber = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            int currentNumber = 0;
            bool[] isTribonacci = new bool[1000000 + 1];
            isTribonacci[trib1] = true;
            isTribonacci[trib2] = true;
            isTribonacci[trib3] = true;
            while (true)
            {
                currentNumber = trib1 + trib2 + trib3;
                trib1 = trib2;
                trib2 = trib3;
                trib3 = currentNumber;
                if (currentNumber>1000000)
                {
                    break;
                }
                isTribonacci[currentNumber] = true;
            }
            int counter = 1;
            bool isCrossed = false;
            while (initialNumber <= 1000000)
            {
                if (isTribonacci[initialNumber] == true)
                {
                    isCrossed = true;
                    Console.WriteLine(initialNumber);
                    break;
                }
                initialNumber += step * (counter / 2);
                counter++;
                
            }
            if (!isCrossed)
            {
                Console.WriteLine("No");
            }
        }
    }
