using System;

class Sunglasses
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int size = input - 2;
        string frame = new string('*', input * 2) + new string(' ', input) + new string('*', input * 2);
        string glass = new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1) + new string(' ', input) + new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1);
        string middle = new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1) + new string('|', input) + new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1);

        Console.WriteLine(frame);
        for (int i = 0; i < size; i++)
        {
            if ((double)i == (Math.Ceiling((double)size / (double)2)) - 1)
            {
                Console.WriteLine(middle);
            }
            else
            {
                Console.WriteLine(glass);
            }
        }
        Console.WriteLine(frame);
    }
}