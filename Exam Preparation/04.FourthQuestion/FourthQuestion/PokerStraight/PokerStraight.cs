﻿using System;

    class Program
    {
        static void Main()
        {
            int w = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i < 11; i++) // това са всичките възможности да имам 5 поредни карти, защото картите са общо 14
            {
                for (int k1 = 1; k1 < 5; k1++) // следващите 5 цикъла въртят бойте за 5 поредни карти
                {
                    for (int k2 = 1; k2 < 5; k2++)
                    {
                        for (int k3 = 1; k3 < 5; k3++)
                        {
                            for (int k4 = 1; k4 < 5; k4++)
                            {
                                for (int k5 = 1; k5 < 5; k5++)
                                {
                                    int currWeight = calcWeight(i, k1, k2, k3, k4, k5); // изчислявам сумата от теглата на 5те карти като си викам метода

                                    if (currWeight == w)
                                    {
                                        count++; // каунтъра ми отброява всеки път когато сме намерили карти с тегло равно на зададеното
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }

        public static int calcWeight(int i, int k1, int k2, int k3, int k4, int k5)
        {
            return (10 * i + k1) + (20 * (i + 1) + k2) + (30 * (i + 2) + k3) +
                 (40 * (i + 3) + k4) + (50 * (i + 4) + k5); // тази формула ми е дадена в заданието
        }
    }

