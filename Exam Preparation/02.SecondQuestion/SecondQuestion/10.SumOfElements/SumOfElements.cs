using System;

class SumOfElements
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        long max = long.MinValue; // тази променлива ще ми пази най-голямото число. Затова в началото я вземам с мин. стойност за да може всяка следваща да е по-голяма и да се презапише.
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int element = int.Parse(numbers[i]);
            sum += element;
            if (element > max) // тук права проверка дали настоящото число е по-голямо от макс.
            {
                max = element; // ако е по-голямо макса взема неговата стойност
            }
        }
        if (sum == 2 * max) // тук проверявам дали сумата на всички числа е равна на макс числото на квадрат
        {
            Console.WriteLine("Yes, sum=" + max);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(sum - 2 * max));
        }
    }
}

