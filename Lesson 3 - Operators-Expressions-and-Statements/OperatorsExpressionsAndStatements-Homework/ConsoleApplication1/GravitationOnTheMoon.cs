using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Please enter your weight: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            if (weightOnEarth > 0)
            {
                double weightOnTheMoon = 0.17 * weightOnEarth;
                Console.WriteLine("Your weight on the Moon is: " + weightOnTheMoon);
            }
            else
            {
                Console.WriteLine("Please enter a positive number!!! ");
            }
            Main();
        }
    }

