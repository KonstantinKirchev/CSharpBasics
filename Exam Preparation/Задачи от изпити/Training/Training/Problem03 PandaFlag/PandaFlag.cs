using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Linq;

class Program
{

    static void Main()
    {

        // panda flag
        int input = int.Parse(Console.ReadLine());

        if(input == 1)
        {
            Console.WriteLine("A");
            Environment.Exit(0);
        }

        char letter = 'A';
        int currentIndex = 0;

        Console.WriteLine(letter + new string('#', input - 2) + (++letter));

        for (int i = 0, poundKey = input - 4, tilde = 1; i < (input / 2) - 1; i++, poundKey -= 2, tilde++)
        {
            if (letter == 'Z')
            {
                letter = '@';
            }
            Console.WriteLine(new string('~', tilde) + new string(++letter, 1) + new string('#', poundKey) + new string(++letter, 1) + new string('~', tilde));
            currentIndex = tilde;
        }

        Console.WriteLine(new string('-', input / 2) + new string(++letter, 1) + new string('-', input / 2));

        for (int i = 0, tilde = currentIndex, poundKey = 1; i < (input / 2) - 1; i++, currentIndex--, poundKey += 2)
        {
            
            Console.Write(new string('~', currentIndex) + new string(++letter, 1) + new string('#', poundKey));
            if (letter == 'Z')
            {
                letter = '@';
            }
            Console.Write(new string(++letter, 1) + new string('~', currentIndex));
            Console.WriteLine();

        }

        Console.WriteLine(++letter + new string('#', input - 2) + (++letter));

    }
}