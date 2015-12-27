using System;

class NewHouse
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string sealing = new string('*', input);
        string floors = new string('|', 1) + new string('*', input - 2) + new string('|', 1);

        for (int i = (input / 2), j = 1; i > 0; i--, j += 2)
        {
            Console.WriteLine(new string('-', i) + new string('*', j) + new string('-', i)); // rooftop
        }
        Console.WriteLine(sealing);
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine(floors);
        }
    }
}