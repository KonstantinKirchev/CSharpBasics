using System;

class BitwiseOperators
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            while (input > 0)
            {
                int bit = input & 1;
                //Console.WriteLine("int bit = input & 1");
                //Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));
                result = (result << 1) | bit;
                //Console.WriteLine("result = (result << 1) | bit");
                //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
                input = input >> 1;
                //Console.WriteLine("input = input >> 1");
                //Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
            }
            Console.WriteLine(result);
        }
    }
}

