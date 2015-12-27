using System;

class XBits
{
    static void Main()
    {
        //input
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //logic
        int countX = 0;
        for (int nIndex = 0; nIndex < 6; nIndex++)
        {
            for (int bitPos = 0; bitPos < 25; bitPos++)
            {
                bool top = ((numbers[nIndex] >> bitPos) & 7) == 5;
                bool mid = ((numbers[nIndex + 1] >> bitPos) & 7) == 2;
                bool bot = ((numbers[nIndex + 2] >> bitPos) & 7) == 5;

                if (top && mid && bot)
                {
                    countX++;
                }
            }
        }

        //output
        Console.WriteLine(countX);
    }
}