using System;

    class BitExchangeAdvanced
    {
        static void Main()
        {
            
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine()); // позицията на първия бит       
            int q = int.Parse(Console.ReadLine()); // позицията на втория бит        
            int k = int.Parse(Console.ReadLine()); // брой битове който да се разменят между 1ви и 2ри битове

            if (Math.Max(p, q) + k - 1 > 31) // Тук проверявам дали по-големият от двата бита + броя битове за смяна ще надхвърли 32 битовото число
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q)) // Тук проверявам дали по-малкият от 2та бита + броя битове за смяна, ще застъпи по-големият
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;
                    uint leftBit = (number & (mask << q)) >> q; // Тук вземам левите битове и ги запазвам в променливата leftBit
                    uint rightBit = (number & (mask << i)) >> i; // Тук вземам десните битове и ги запазвам в променливата rightBit
                    number &= ~(mask << i); // Тук нулирам битовете на позиция p(защото i приема p -> виж горе в for цикъла)
                    number &= ~(mask << q); // Тук нулирам битовете на позиция q
                    number |= (leftBit << i); // Тук разменям битовете на вече нулираните позиции
                    number |= (rightBit << q); // Тук разменям битовете на вече нулираните позиции
                    q++; // това е нужно за да нараства q при всяка итерация на i(p)
                }
                Console.WriteLine(number);
            }
        }
    }

