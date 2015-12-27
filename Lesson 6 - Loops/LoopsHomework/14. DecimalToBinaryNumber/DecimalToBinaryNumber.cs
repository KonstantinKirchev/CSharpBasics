using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter your decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        long rest;
        string binary = string.Empty;
        if (decimalNumber==0)
        {
            Console.WriteLine(decimalNumber);
        }
        else
        {
            while (decimalNumber > 0)
            {
                rest = decimalNumber % 2;
                decimalNumber /= 2;
                binary = rest.ToString() + binary;
            }

            Console.WriteLine(binary);
        }
        
        Main();
    }
}
