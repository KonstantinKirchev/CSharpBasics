using System;
using System.Collections.Generic;

    class MorseCodeNumbers
    {
        static void Main()
        {
            Dictionary<int, string> morseEncoding = new Dictionary<int, string>    
            {
                
            {1,  ".----"}, 
            {2,  "..---"}, 
            {3,  "...--"}, 
            {4,  "....-"}, 
            {5,  "....."}

            };
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number != 0)
	        {
                int remainder = number % 10; // така вземам всяка цифра от числото което ми е подадено на входа
                sum += remainder; // и я прибавям към сумата
                number /= 10; // после вземам следващата цифра
	        }

            bool hasAnswere = false;
            long morseProduct = 1;
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    for (int k = 1; k <= 5; k++)
                    {
                        for (int l = 1; l <= 5; l++)
                        {
                            for (int h = 1; h <= 5; h++)
                            {
                                for (int g = 1; g <= 5; g++)
                                {
                                    morseProduct = i * j * k * l * h * g;
                                    if (morseProduct==sum)
                                    {
                                        //Console.WriteLine("morseProduct = {0}*{1}*{2}*{3}*{4}*{5} = {6}",i,j,k,l,h,g,morseProduct);
                                        Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|",morseEncoding[i],morseEncoding[j],morseEncoding[k],
                                            morseEncoding[l],morseEncoding[h],morseEncoding[g]); // вземам точките и тиренцата от речника и ги отпечатвам
                                        hasAnswere = true;
                                    }
                                }   
                            }
                        }
                    }
                }
            }
            if (hasAnswere == false)
            {
                Console.WriteLine("No");
            }
        }
    }

