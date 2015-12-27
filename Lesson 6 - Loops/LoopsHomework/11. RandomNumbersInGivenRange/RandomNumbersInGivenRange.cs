using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < counter; i++)
            {
                int randomNumber = random.Next(min, max);
                Console.Write("{0} ",randomNumber);
            }
            Console.WriteLine();
            Main();
        }
    }

