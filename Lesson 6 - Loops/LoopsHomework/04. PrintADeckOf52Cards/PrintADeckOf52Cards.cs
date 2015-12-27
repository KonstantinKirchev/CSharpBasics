using System;

    class PrintADeckOf52Cards
    {
        static void Main()
        {
            char hearts = (char)3;
            char diamonds = (char)4;
            char clubs = (char)5;
            char spades = (char)6;
            for (int i = 2; i < 11; i++)
            {
                Console.WriteLine("{0,2}{1}{0,2}{2}{0,2}{3}{0,2}{4}", i, clubs, diamonds, hearts, spades);
            }
            for (int cards = 1; cards <= 4; cards++)
            {
                switch (cards)
                {
                    case 1:
                        Console.WriteLine(" J{0} J{1} J{2} J{3}", clubs, diamonds, hearts, spades);
                        break;
                    case 2:
                        Console.WriteLine(" Q{0} Q{1} Q{2} Q{3}", clubs, diamonds, hearts, spades);
                        break;
                    case 3:
                        Console.WriteLine(" K{0} K{1} K{2} K{3}", clubs, diamonds, hearts, spades);
                        break;
                    case 4:
                        Console.WriteLine(" A{0} A{1} A{2} A{3}", clubs, diamonds, hearts, spades);
                        break;
                    default:
                        break;
                }
                
            }
        }
    }

