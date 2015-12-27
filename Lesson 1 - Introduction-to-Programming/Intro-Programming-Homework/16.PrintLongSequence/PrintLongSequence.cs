using System;
    class PrintLongSequence
    {
        static void Main()
        {
            uint positiveNumber = 2;
            int negativeNumber = -3;
            for (positiveNumber = 2, negativeNumber = -3; positiveNumber < 1002 || negativeNumber > -1002; positiveNumber += 2, negativeNumber -= 2)
            {
                Console.Write("{0},{1},", positiveNumber, negativeNumber);
            }
            Console.WriteLine();

            if (positiveNumber > 1001)
            {
                Console.WriteLine("Well Done");
            }
        }
    }