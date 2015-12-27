using System;

    class NumInIntDivByGiveNum
    {
        static void Main()
        {   
            Console.Write("start= ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("end= ");
            int secondNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;            
                    Console.Write("{0}, ",i);   
                }
            }
                    Console.WriteLine();
                    Console.WriteLine("p="+counter);
                    Main();
        }
    }

