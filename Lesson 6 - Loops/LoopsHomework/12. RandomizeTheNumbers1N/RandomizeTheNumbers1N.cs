using System;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        bool[] printed = new bool[counter + 1];
        Random random = new Random();

        for (int i = 0; i < counter; i++)
        {
            int randomNumber = random.Next(1, counter + 1);
            if (!printed[randomNumber])
            {
                Console.Write("{0} ", randomNumber);
                printed[randomNumber] = true;
            }
            else
            {
                i--;
            }
        }         
    }
 }


