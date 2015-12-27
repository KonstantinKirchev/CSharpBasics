using System;

class House
{
    static void Main()
    {
        //Console.Write("Please enter an odd number in the range of (5-49)= ");
        int number = int.Parse(Console.ReadLine());
        //if (number < 5 || number > 49)
        //{
        //    Console.WriteLine("The number is not in the range of (5-49)");
        //}
        //if (number >= 5 && number <= 49)
        //{
        //    if (number % 2 != 0)
        //    {
        Console.WriteLine(new string('.', number / 2)
                        + new string('*', 1)
                        + new string('.', number / 2));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', (number / 2 - 1) - i)
                            + new string('*', 1)
                            + new string('.', 1 + 2 * i)
                            + new string('*', 1)
                            + new string('.', (number / 2 - 1) - i));
        }
        Console.WriteLine(new string('*', number));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', number / 4)
                            + new string('*', 1)
                            + new string('.', number - (2 * (number / 4) + 2))
                            + new string('*', 1)
                            + new string('.', number / 4));
        }
        Console.WriteLine(new string('.', number / 4)
                        + new string('*', number - 2 * (number / 4))
                        + new string('.', number / 4));
    }
}
//        Main();
//    }
//}

