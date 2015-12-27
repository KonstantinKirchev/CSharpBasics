using System;

class Triangle
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
                Console.WriteLine("*", row);
           
            
        }
        Console.WriteLine();
    }
}
