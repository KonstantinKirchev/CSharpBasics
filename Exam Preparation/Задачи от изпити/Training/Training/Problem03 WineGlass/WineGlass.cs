using System;

class WineGlass
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int size = 0, linesToAdd = 0, counter = 0;
        if (input >= 12)
        {
            size = (input / 2) - 2;
            linesToAdd++;
        }
        else
        {
            size = (input / 2) - 1;
        }

        for (int i = 0, j = 2; i < input / 2; i++, j += 2)
        {
            Console.WriteLine(new string('.', i) + new string('\\', 1) + new string('*', input - j) + new string('/', 1) + new string('.', i));
            counter++;
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(new string('.', size + linesToAdd) + new string('|', 2) + new string('.', size + linesToAdd));
            counter++;
        }
        for (int i = 0; i < input - counter; i++)
        {
            Console.WriteLine(new string('-', input));
        }
    }
}