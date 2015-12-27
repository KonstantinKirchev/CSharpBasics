using System;

class PrintASequence
{
    static void Main()
    {
        uint positiveNum = 2;
        int negativeNum = -3;
        for (positiveNum = 2, negativeNum = -3; positiveNum < 12 || negativeNum > -12; positiveNum += 2, negativeNum -= 2)
        {
            Console.Write("{0},{1},", positiveNum, negativeNum);
        }
            Console.WriteLine();
    }
}
