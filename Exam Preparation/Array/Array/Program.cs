using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string bitNumber = Convert.ToString(number, 2).PadLeft(32, '0');
            char[] charArrayNumber = bitNumber.ToCharArray();
            Console.WriteLine(charArrayNumber);
            

        }
    }

