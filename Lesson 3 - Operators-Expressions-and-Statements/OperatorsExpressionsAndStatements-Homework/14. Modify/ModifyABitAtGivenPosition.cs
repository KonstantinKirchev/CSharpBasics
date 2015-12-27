using System;

    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("n= ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("p= ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("v= ");
            int bitValue = int.Parse(Console.ReadLine());
            if (bitValue==0)
            {
                int mask = ~1;      
                int result = number & mask << position;     
                Console.WriteLine("Result: " + result); 
                Console.WriteLine("Binary result: "+Convert.ToString(result, 2).PadLeft(16, '0'));
            }
            else
            {
                int mask = 1;
                int result = number | mask << position;     
                Console.WriteLine("Result: " + result); 
                Console.WriteLine("Binary result: "+Convert.ToString(result, 2).PadLeft(16, '0'));
            }
            Console.WriteLine();
            Main();
        }
    }

