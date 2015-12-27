using System;

class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine()); // Insert commands can cause overflow of int
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

        string order = Console.ReadLine();

        while (order != "quit")
        {
            int position = int.Parse(order);
            order = Console.ReadLine();

            long mask = 0L;

            if (position != 0)
            {
                string str = new string('1', position);
                mask = Convert.ToInt32(str, 2);
            }

            long rightBits = number & mask; // save bits to the left of position for later use

            switch (order)
            {
                case "flip":
                    number ^= 1 << position;
                    break;
                case "insert":
                    number = number >> position;
                    //Console.WriteLine("number >> position");
                    //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                    number = number << (position + 1);
                    //Console.WriteLine("number << (position + 1)");
                    //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                    long mask2 = ((long)1 << position);
                    //Console.WriteLine("mask 2 = ((long)1 << position)");
                    //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                    number = number | mask2;
                    //Console.WriteLine("number = number | mask2");
                    //Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(64, '0'));

                    number = number | rightBits;
                    break;
                case "remove":
                    number = (number >> position + 1);
                    //Console.WriteLine("(number >>  position + 1);");
                    //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                    number = number << position;
                    //Console.WriteLine(" number = number << position;");
                    // Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                    number = number | rightBits;
                    break;
            }

            //Console.WriteLine("number after command");
            // Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

            order = Console.ReadLine(); // receive new order after first is executed
        }

        Console.WriteLine(number);
    }
}