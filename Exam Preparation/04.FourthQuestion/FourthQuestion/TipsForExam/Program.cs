using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

        I.
            Dictionary<char, int> lettersWeight = new Dictionary<char, int>    
            {            
            {'a',  5},
            {'b',-12},
            {'c', 47},
            {'d',  7},
            {'e',-32}       
            };
        II.
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
       III.
            int[] letters =    {'A' - 'A' + 1, 
                                'B' - 'A' + 1, 
                                'C' - 'A' + 1, 
                                'E' - 'A' + 1, 
                                'H' - 'A' + 1, 
                                'K' - 'A' + 1, 
                                'M' - 'A' + 1, 
                                'P' - 'A' + 1, 
                                'T' - 'A' + 1, 
                                'X' - 'A' + 1}; // вкарвам си всички тежести на съответните букви в един масив
        IV.
            DateTime startDate = new DateTime(startYear,1,1);
            DateTime endDate = new DateTime(endYear,12,31);
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                string number = "" + i.Day; // По този начин си взимам всички числа от датата, долепям ги едно до друго и ги превръщам в стринг
                number += i.Month; // същото правя за месеца
                number += i.Year; // и годината
        V.
            string firstLeft = firstWord.Substring(0, firstDivider); // тук режа думата на лява и дясна част чрез функцията Substring
       VI.
             static long CalculateWeight(string word)
            {
                long sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    sum += (int)word[i]; // тук вземам всяка буква и я сумирам със следващата и така до края на думата
                }

                return sum;
            }
       VII.
             public static int calcWeight(int i, int k1, int k2, int k3, int k4, int k5)
        {
            return (10 * i + k1) + (20 * (i + 1) + k2) + (30 * (i + 2) + k3) +
                 (40 * (i + 3) + k4) + (50 * (i + 4) + k5); // тази формула ми е дадена в заданието
        }
       VIII.
            string input = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += (input[i] - 'a' + 1);
            }

        }
    }

