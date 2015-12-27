using System;

    class Gambling
    {
        static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            string[] housesHand = Console.ReadLine().Split();
            int housesStrength = 0;
            foreach (var card in housesHand) // така минавам през всички карти на банката и събирам техните стойности
            {
                switch (card)
                {
                    case "J":
                        housesStrength += 11;
                        break;
                    case "Q":
                        housesStrength += 12;
                        break;
                    case "K":
                        housesStrength += 13;
                        break;
                    case "A":
                        housesStrength += 14;
                        break;
                    default:
                        housesStrength += int.Parse(card); // картите от 2 до 10 са с тяхната стойност
                        break;
                }
            }
            int countWinning = 0;
            int totalHands = 0;
            for (int card1 = 2; card1 < 15; card1++)
            {
                for (int card2 = 2; card2 < 15; card2++)
                {
                    for (int card3 = 2; card3 < 15; card3++)
                    {
                        for (int card4 = 2; card4 < 15; card4++)
                        {
                            int myPower = card1 + card2 + card3 + card4;
                            if (myPower > housesStrength) 
                            {
                                countWinning++; // тук отброявам по-силните комбинации от ръце от тези на банката
                            }
                            totalHands++; // тук отброявам всички комбинации
                        }
                    }
                }
            }
            decimal probability = (decimal)countWinning / totalHands; // вероятността да спечеля е по-силните комбинации разделени на всички комбинации
            if (probability < 0.5m)
            {
                Console.WriteLine("FOLD");
            }
            else
            {
                Console.WriteLine("DRAW");
            }
            decimal expectedWinnings = probability * 2 * cash; // очакваната печалба е вероятността * 2 * всички пари на масата
            Console.WriteLine("{0:F2}", expectedWinnings);

        }
    }

