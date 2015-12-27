using System;

    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter your binary number: ");
            string binaryNumber = Console.ReadLine();

            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[binaryNumber.Length - i - 1] == '0')
                {
                    continue;
                }
                decimalNumber += (long)Math.Pow(2, i);
            }
            Console.WriteLine(decimalNumber);
            Main();
        }
    }

