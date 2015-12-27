using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Please enter a four-digit number: ");
            int number = int.Parse(Console.ReadLine());
            if (number>=1000 && number<=9999)
            {
                int firstDigit = (number / 1000) % 10;
                int secondDigit = (number / 100) % 10;
                int tirthDigit = (number / 10) % 10;
                int fourthDigit = number % 10;
                Console.WriteLine("sum of digits: " + (firstDigit + secondDigit + tirthDigit + fourthDigit));
                Console.WriteLine("reverse order: " + fourthDigit + tirthDigit + secondDigit + firstDigit);
                Console.WriteLine("last digit in front: " + fourthDigit + firstDigit + secondDigit + tirthDigit);
                Console.WriteLine("second and tirth digit exchanged: " + firstDigit + tirthDigit + secondDigit + fourthDigit);
                Console.WriteLine();
            }
            Main();
        }
    }

