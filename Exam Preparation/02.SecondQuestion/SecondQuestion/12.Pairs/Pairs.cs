using System;
using System.Linq;

class Pairs
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split(' ');

        int firstElement = int.Parse(elements[0]); // взимам първото число
        int secondElement = int.Parse(elements[1]); // взимам второто число
        int prevValue = firstElement + secondElement; // сумирам ги

        int maxdiff = 0; // в условието е казано, че разликата между всяка двойка от числа е положително число. Иначе се записва Int32.MinValue
        for (int i = 2; i < elements.Length - 1; i += 2)
        {
            firstElement = int.Parse(elements[i]);
            secondElement = int.Parse(elements[i + 1]);
            int lastValue = firstElement + secondElement;
            int diff = Math.Abs(lastValue - prevValue); // тук намирам разликата между сумите на две поредни двойки числа
            maxdiff = Math.Max(diff, maxdiff); // тук намирам максималната разлика
            prevValue = lastValue; // и тук приравнявам 1вата сума на 2рата, за да използвам 2рата като първа и да я сравня със следващата двойка числа в цикъла
        }

        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value=" + prevValue); // ако няма разлика между сумите на двойките числа
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxdiff); // ако има разлика между сумите на двойките числа
        }
    }

}

