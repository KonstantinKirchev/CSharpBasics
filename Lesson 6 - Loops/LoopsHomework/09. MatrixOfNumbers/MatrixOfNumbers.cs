using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n>=1 && n<=20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int column = 1; column <= n; column++)
                    {
                        Console.Write("{0} ", column + row - 1);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }           
            Main();
        }
    }
