using System;
using System.Linq;

class SequenceOfKNumbers
{
    static void Main()
    {
        string inputLine = Console.ReadLine(); // подават ми стринг от числа
        int k = int.Parse(Console.ReadLine()); // а тук броя поредни числа който трябва да пропусна

        inputLine = inputLine + " " + int.MaxValue;
        string[] inputTokens = inputLine.Split(' ');
        int equalCount = 1; // каунта почва от 1 , защото съм си взел предварително първото число.
        int prev = int.Parse(inputTokens[0]); // вземам си първото число
        for (int i = 1; i < inputTokens.Length; i++)
        {
            int num = int.Parse(inputTokens[i]); // това е 2рото число
            if (num == prev) // проверявам дали 1вото е равно на 2рото
            {
                equalCount++; // тук отброявам еднаквите числа
            }
            else
            {
                // Print (count % k) times the number num
                for (int counter = 0; counter < equalCount % k; counter++)
                {
                    Console.Write(prev + " "); // ако не са еднакви ги отпечатвам
                }
                equalCount = 1; // нулирам каунта да почва от чвото число
            }
            prev = num; // тук приравнявам 1вото и 2рото и се връщам горе да проверявам 3тото число и т.н.
        }
    }
}

