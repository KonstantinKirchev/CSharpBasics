using System;
class Eclipse
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string frame = new string(' ', 1) + new string('*', (input * 2) - 2) + new string(' ', input + 1) + new string('*', (input * 2) - 2);
        Console.WriteLine(frame);
        for (int i = 0; i < input - 2; i++)
        {
            if (i == (input - 2) / 2)
            {
                Console.WriteLine(new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1) + new string('-', input - 1) + new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1));
            }
            else
            {
                Console.WriteLine(new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1) + new string(' ', input - 1) + new string('*', 1) + new string('/', (input * 2) - 2) + new string('*', 1));
            }

        }
        Console.WriteLine(frame);
    }
}