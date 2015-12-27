using System;

class Debugger
{
    static void Main()
    {
        Console.BufferHeight = 2000;
        int counter = 0;
        for (int number = 1; number <= 1000; number++)
        {
            Console.WriteLine("{0}", number);
            counter++;
        }
        Console.WriteLine("{0} combinations", counter);
    }
}
