using System;

    class SquareRoot
    {
         public static void Main()
         {
             Console.Write("Give me a number and I will square rooted it for you: ");
             int number = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Here is your answere: " + Math.Sqrt(number).ToString());
             Main();
         }
    }

