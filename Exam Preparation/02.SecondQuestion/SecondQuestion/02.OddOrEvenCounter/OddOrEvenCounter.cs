using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int setCount = int.Parse(Console.ReadLine());
        int numberSet = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();

        int[] totalCount = new int[setCount];
        for (int index = 0; index < setCount; index++) // външен каунт на сетовете от числа 
        {
            for (int innerIndex = 0; innerIndex < numberSet; innerIndex++) // вътрешен каунт на самите числа
            {
                int currentNumber = int.Parse(Console.ReadLine()); // тук си прочитам всяко число
                if (type == "odd")
                {
                    if (currentNumber % 2 == 1) // вземам нечетните числа
                    {
                        totalCount[index]++; // и ги отброявам
                    }
                }
                else
                {
                    if (currentNumber % 2 == 0) // вземам четните числа
                    {
                        totalCount[index]++; // и ги отброявам
                    }
                }
            }
        }

        int maxCount = 0;
        int maxIndex = -1;

        for (int index = 0; index < totalCount.Length; index++) // това ми е броя на сетовете
        {
            if (totalCount[index] > maxCount) // ако първият сет е по-голям от нула влиза вътре. След това ако втория сет има повече числа от maxCount влиза вътре.
            {
                maxCount = totalCount[index]; // maxCount вече не е 0 а е приравнен на броя на четните(нечетните) числа от първия сет. Така и за втория и т.н. 
                maxIndex = index; // 1вия сет става с най-много числа.после се повтаря цикъла и ако втория сет има повече числа то те се презаписват.
            }
        }

        if (maxCount == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            switch (maxIndex + 1)
            {
                case 1:
                    Console.Write("First");
                    break;
                case 2:
                    Console.Write("Second");
                    break;
                case 3:
                    Console.Write("Third");
                    break;
                case 4:
                    Console.Write("Fourth");
                    break;
                case 5:
                    Console.Write("Fifth");
                    break;
                case 6:
                    Console.Write("Sixth");
                    break;
                case 7:
                    Console.Write("Seventh");
                    break;
                case 8:
                    Console.Write("Eighth");
                    break;
                case 9:
                    Console.Write("Ninth");
                    break;
                case 10:
                    Console.Write("Tenth");
                    break;
            }
            Console.WriteLine(" set has the most {0} numbers: {1}", type, maxCount); // maxCount ми държи бройката на числата в конкретният сет от числа.
        }
    }
}


