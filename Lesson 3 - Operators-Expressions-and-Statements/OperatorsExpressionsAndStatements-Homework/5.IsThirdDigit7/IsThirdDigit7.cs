using System;

    class IsThirdDigit7
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Write("The third digid is 7 : ");
            bool thirdDigit = (number / 100) % 10 == 7;
            Console.WriteLine(thirdDigit);
            Main();
        }
    }

