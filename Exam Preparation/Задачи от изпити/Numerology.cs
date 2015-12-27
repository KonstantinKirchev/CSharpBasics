using System;

class Numerology
{
    static void Main()
    {
        string[] inputData = Console.ReadLine().Split('.',' ');

        int date = int.Parse(inputData[0]);
        int month = int.Parse(inputData[1]);
        int year = int.Parse(inputData[2]);
        string userName = inputData[3];

        long multiplication = date * month * year;
        if (month % 2 != 0)
        {
            multiplication *= multiplication;
        }

        long celNumber = 0;
        char letter = '\0';
        for (int i = 0; i < userName.Length; i++)
        {
            letter = userName[i];
            if (Char.IsUpper(letter))
            {
                celNumber += (letter - 64) * 2;
            }
            else if (Char.IsLower(letter))
            {
                celNumber += letter - 96;
            }
            else if (Char.IsDigit(letter))
            {
                celNumber += letter - 48;
            }
        }
        celNumber += multiplication;
        if (celNumber > 13)
        {
            string digits = "" + celNumber;
            int length = digits.Length;
            
            long sum = 0;
            while (celNumber > 0)
            {
                long digit = 0;
                digit = (celNumber / (long)Math.Pow(10, length - 1)) % 10;
                length--;
                sum += digit;
 
            }
            if (sum > 13)
            {
                long sum2 = 0;
                string digits2 = "" + sum;
                int len2 = digits2.Length;
                long sum3 = 0;
                while (sum > 0)
                {
                    long digit2 = 0;
                    digit2 = (sum / (long)Math.Pow(10, len2 - 1)) % 10;
                    len2--;
                    sum += digit2;
                }
                if (sum3 > 13)
                {
                    Console.WriteLine(sum3);
                }
                else
                {
                    Console.WriteLine(sum3);
                }
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
        else 
        {
            Console.WriteLine(celNumber);
        }
         
    }
}