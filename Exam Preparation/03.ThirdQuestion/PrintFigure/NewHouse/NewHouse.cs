using System;

class NewHouse
{
    static void Main()
    {
        //Console.Write("Please enter an odd number in the range of (3-101)= ");
        int number = int.Parse(Console.ReadLine());
        //if (number < 3 || number > 101)
        //{
        //    Console.WriteLine("The number is not in the range of 3-101");
        //}
        //if (number >= 3 && number <= 101)
        //{
        //    if (number % 2 != 0)
        //    {
        for (int i = 0; i < number / 2; i++)
        {
            Console.WriteLine(new string('-', number / 2 - i)
                            + new string('*', 1 + 2 * i)
                            + new string('-', number / 2 - i));
        }
        Console.WriteLine(new string('*', number));
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(new string('|', number - (number - 1))
                            + new string('*', number - 2)
                            + new string('|', number - (number - 1)));
        }

    }
}
//    Main();
//}
//}