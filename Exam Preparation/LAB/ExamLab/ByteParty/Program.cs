using System;

class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        uint[] number = new uint[counter];
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = uint.Parse(Console.ReadLine());
        }
        string order = Console.ReadLine();
        while (order != "party over")
        {
            string[] input = order.Split();
            int command = int.Parse(input[0]);
            int position = int.Parse(input[1]);
            for (int i = 0; i < number.Length; i++)
            {
                switch (command)
                {
                    case -1: // flip
                        number[i] ^= (uint)1 << position;
                        break;
                    case 0: // turn bit to 0
                        uint mask = (uint)(~(1 << position));
                        number[i] = number[i] & mask;
                        break;
                    case 1: // turn bit to 1
                        uint mask2 = (uint)(1 << position);
                        number[i] = number[i] | mask2;
                        break;
                }
            }
            order = Console.ReadLine();
        }
        foreach (var item in number)
        {
            Console.WriteLine(item);
        }
    }
}

