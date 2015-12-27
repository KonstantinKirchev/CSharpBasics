using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('.', ' '); // това е най-добрият начин да си вземa всичко от стринга.Дали е число или дума, няма значение.

            int day = int.Parse(input[0]);
            int month = int.Parse(input[1]);
            int year = int.Parse(input[2]);
            string username = input[3];

            long result = day * month * year;

            if (month % 2 == 1) // проверявам дали месеца е нечетен
            {
                result *= result;
            }

            for (int i = 0; i < username.Length; i++) // правя цикъл за да обходя всички символи от стринга
            {
                char currentChar = username[i]; // вземам всеки чар от стринга и го проверявам с if-овете и после го добавям към result

                if (currentChar >= '0' && currentChar <= '9')
                {
                    result += currentChar - '0';
                }
                else if (currentChar >= 'a' && currentChar <= 'z')
                {
                    result += currentChar - 'a' + 1;
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    result += 2 * (currentChar - 'A' + 1);
                }
            }

            while (result > 13)
            {
                int digitSum = 0; // създавам нова променлива в която ще сумирам всички цифри от result

                while (result > 0)
                {
                    digitSum += (int)(result % 10); // по този начин вземам всяка цифра съставляваща числото "result""
                    result /= 10; // след това деля на 10, за да взема следващата цифра. И така докато не взема всички цифри и ги сумирам.
                }

                result = digitSum; // приравнявам новата сума с result и проверявам дали е по-малък от 13. Ако е по-голям продължавам да цепя числото и да сумирам резултата.
            }

            Console.WriteLine(result); 
        }
    }

