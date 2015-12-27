using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.Write("Character= ");
            string character = Console.ReadLine();

            switch (character)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Valid Card Sign? yes");
                    break;
                default:
                    Console.WriteLine("Valid Card Sign? no");
                    break;
            }
            Main();
        }
    }

