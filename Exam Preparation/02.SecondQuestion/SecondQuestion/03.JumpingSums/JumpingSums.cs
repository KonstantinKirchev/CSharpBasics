using System;

    class JumpingSums
    {
        static void Main()
        {
            string[] numbersAsStrings = Console.ReadLine().Split(); // цепя числата от стринга
            int jumps = int.Parse(Console.ReadLine()); // това са ми подскоците
            int[] numbers = new int[numbersAsStrings.Length]; // правя си нов инт масив с дължината на стринга
            for (int i = 0; i < numbersAsStrings.Length; i++) // правя си цикъл за да си взема числата и да ги вкарам в масив инт
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }
            int maxSum = int.MinValue; // това го правя за да намеря максималната сума
            for (int i = 0; i < numbers.Length; i++) // цикля в масива от числа до неговата дължина
            {
                int index =i;
                int currentSum = numbers[index]; // инициализирам си текуща сума започваща от първото число в масива
                for (int j = 0; j < jumps; j++) // правя си вложен цикъл за подскоците който ще върти до броя подскоци
                {
                    index = (index + numbers[index]) % numbers.Length;
                    currentSum += numbers[index]; // това е сума на числата след подскоците
                }
                maxSum = Math.Max(maxSum, currentSum); // тук сравнявам двете суми и взимам по-голямата
            }
            Console.WriteLine("max sum = {0}", maxSum); // и я отпечатвам
        }
    }

