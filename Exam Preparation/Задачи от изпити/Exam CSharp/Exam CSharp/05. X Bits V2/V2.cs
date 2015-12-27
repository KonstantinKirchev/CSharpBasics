using System;

class V2
{
    static void Main()
    {
        //input
        int countX = 0;
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;

        for (int i = 0; i < 6; i++)
        {
            if (i == 0)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                num3 = int.Parse(Console.ReadLine());
            }
            else
            {
                num1 = num2;
                num2 = num3;
                num3 = int.Parse(Console.ReadLine());
            }
            //logic
            for (int bitPos = 0; bitPos < 32; bitPos++)
            {
                bool top = ((num1 >> bitPos) & 7) == 5;
                bool mid = ((num2 >> bitPos) & 7) == 2;
                bool bot = ((num3 >> bitPos) & 7) == 5;

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