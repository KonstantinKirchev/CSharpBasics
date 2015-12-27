using System;
using System.Collections.Generic;

class BullsAndCows
{
    const int Digit = 4;

    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool isTrue = false;
        for (int guessNumber = 1111; guessNumber < 10000; guessNumber++)
        {
            int bullsFound = GetBulls(secretNumber, guessNumber);
            int cowsFound = GetCows(secretNumber, guessNumber);
            if (bulls == bullsFound && cows == cowsFound)
            {
                if (guessNumber.ToString().IndexOf('0') == -1) // така намира нулевите чарове и ги премахва
                {
                    Console.Write(guessNumber);
                    Console.Write(" ");
                    isTrue = true;
                }
            }
        }
        if (!isTrue)
        {
            Console.WriteLine("No");
        }
    }

    private static int GetBulls(int secretNumber, int guessNumber)
    {
        //int d1 = (secretNumber / 1000) % 10; // 1ви вариант да си взема числата!!!
        //int d2 = (secretNumber / 100) % 10;
        //int d3 = (secretNumber / 10) % 10;
        //int d4 = (secretNumber / 1) % 10;

        //char sec0 = secretNumber.ToString()[0]; // 2ри вариант да си взема числата като чарове
        //char sec1 = secretNumber.ToString()[1];
        //char sec2 = secretNumber.ToString()[2];
        //char sec3 = secretNumber.ToString()[3];

        //char guess0 = guessNumber.ToString()[0];
        //char guess1 = guessNumber.ToString()[1];
        //char guess2 = guessNumber.ToString()[2];
        //char guess3 = guessNumber.ToString()[3];

        //int bullsCount = 0;
        //if (sec0==guess0)
        //{
        //    bullsCount++;
        //}
        //if (sec1 == guess1)
        //{
        //    bullsCount++;
        //}
        //if (sec2 == guess2)
        //{
        //    bullsCount++;
        //}
        //if (sec3 == guess3)
        //{
        //    bullsCount++;
        //}
        string secretNum = secretNumber.ToString().PadLeft(Digit, '0');
        string guessNum = guessNumber.ToString().PadLeft(Digit, '0');
        int bullsCount = 0;
        for (int i = 0; i < Digit; i++)
        {
            if (secretNum[i] == guessNum[i])
            {
                bullsCount++;
            }
        }
        return bullsCount;
    }
    private static int GetCows(int secretNumber, int guessNumber)
    {
        List<char> secChars = new List<char>();
        for (int i = 0; i < Digit; i++)
        {
            int digit = secretNumber % 10;
            string digitStr = "" + digit; // така записвам числото в стринг
            char digitCh = digitStr[0]; // така достъпвам всеки чар от стринга
            //secChars.Add(digitCh); // така вкарвам чаровете в листа
            secChars.Insert(0, digitCh); // така ги вкарвам подредени
            secretNumber /= 10;
        }
        List<char> guessChars = new List<char>();
        for (int i = 0; i < Digit; i++)
        {
            int digit = guessNumber % 10;
            string digitStr = "" + digit; // така записвам числото в стринг
            char digitCh = digitStr[0]; // така достъпвам всеки чар от стринга
            //secChars.Add(digitCh); // така вкарвам чаровете в листа
            guessChars.Insert(0, digitCh); // така ги вкарвам подредени
            guessNumber /= 10;
        }

        for (int i = 0; i < Digit; i++)
        {
            if (guessChars[i] == secChars[i])
            {
                // we have a bull --> delete it
                guessChars[i] = '*';
                secChars[i] = '*';
            }
        }
        int cowsCount = 0;
        for (int secIndex = 0; secIndex < Digit; secIndex++)
        {
            for (int guessIndex = 0; guessIndex < Digit; guessIndex++)
            {
                if (secChars[secIndex] == guessChars[guessIndex] && secChars[secIndex] != '*')
                {
                    cowsCount++;
                    secChars[secIndex] = '*';
                    guessChars[guessIndex] = '*';
                }
            }
        }

        return cowsCount;
        //string secretNum = secretNumber.ToString().PadLeft(Digit, '0');
        //string guessNum = guessNumber.ToString().PadLeft(Digit, '0');
        //char[] secretNum = secretNumber.ToString().PadLeft(Digit, '0').ToCharArray();
        //char[] guessNum = guessNumber.ToString().PadLeft(Digit, '0').ToCharArray();
        //bool[] secNumDigitUsed = new bool[4]; 
        //int bullsCount = 0;
        //for (int i = 0; i < Digit; i++)
        //{
        //    if (secretNum[i] == guessNum[i])
        //    {
        //        bullsCount++;
        //    }
        //}
        //return bullsCount;
    }
}

