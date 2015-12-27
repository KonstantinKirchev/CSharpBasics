using System;

class BitSwapper
{
    public static void Main()
    {
        uint[] numbers = new uint[4]; // Правя си масив от 4ри елемента, защото винаги ще ми подават 4ри числа
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine()); // В for цикъла си пълня масива със 4те числа
        }
        while (true)
        {
            string[] from = Console.ReadLine().Split(' '); // Тук си вземам първите 2 числа. Може да ми бъде подадено още тук "End"!!!
            if (from[0] == "End") // Тук проверявам дали не ми е даден order "End"!!!
            {
                break; // С тази функция излизам и прекратявам програмата 
            }
            string[] to = Console.ReadLine().Split(' '); // а тук вторите 2 числа

            int firstNumber = int.Parse(from[0]);     // Вземам 1вото число от 1вия масив което ми е първото число което ще обработват и го парсвам към инт.
            int secondNumber = int.Parse(to[0]);      // Вземам 1вото число от 2рия масив което ми е второто число което ще обработват и го парсвам към инт.
            int firstGroup = int.Parse(from[1]) * 4;  // Вземам 2рото число от 1вия масив което ми е позицията която ще разменям и го парсвам към инт.Умножавам го по 4, за да взема група от 4ри бита!!!
            int secondGroup = int.Parse(to[1]) * 4;   // Вземам 2рото число от 2рия масив което ми е позицията която ще разменям и го парсвам към инт.Умножавам го по 4, за да взема група от 4ри бита!!!

            uint fromMask = 15u << firstGroup; // маската ми е 1111, защото имам да разменям 4ри бита
            uint toMask = 15u << secondGroup; // маската ми е 1111, защото имам да разменям 4ри бита
            uint fromByte = (numbers[firstNumber] & fromMask) >> firstGroup; // вземам си байта на първото число
            uint toByte = (numbers[secondNumber] & toMask) >> secondGroup; // вземам си байта на второто число

            // zeroing the 2 groups that will be swaped
            numbers[firstNumber] &= ~fromMask;
            numbers[secondNumber] &= ~toMask;

            // swaping
            numbers[firstNumber] |= toByte << firstGroup;
            numbers[secondNumber] |= fromByte << secondGroup;
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

