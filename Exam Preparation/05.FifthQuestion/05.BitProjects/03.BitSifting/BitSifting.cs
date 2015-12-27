using System;

class BitSifting
{
    static void Main()
    {
        ulong numberToSieve = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong number = numberToSieve;
        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            number |= sieve;
            number ^= sieve;
        }
        //Console.WriteLine(number);
        int counter = 0;
        while (number != 0)
        {
            ulong diff = number - 1;
            number = number & diff;
            counter++;
        }
        Console.WriteLine(counter);
    }
    static int CountBitOne(int number)
    {
        int counter = 0;

        while (number != 0)
        {
            /*
            * In this way we working at binary notation. When use '-' at binary notation we extracting ones. 
            * Example: 5 - 1 = 4 in binary is like this:
            *   0101 | Then we using bitwise operator '&' to remove ones thats not need anymore.
            * - 0001 | If you don't use '&' your while never stop becouse you have only one operation.
            * -------| At the example we have 5 so number will be equal to 4 and 4 != 0 and will never be equal with zero.
            *   0100 | Be carefully when working with bitwise operations. When we use '&' we changing value of number integer.
            *   Use workbook and work with binary notation to get more experience
            */
            int diff = number - 1;
            number = number & diff;
            counter++;
        }
        return counter;
    }
}

