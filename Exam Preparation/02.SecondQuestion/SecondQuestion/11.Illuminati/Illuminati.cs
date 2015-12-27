using System;

    class Illuminati
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string letters = message.ToUpper(); // обръщам всички букви да са главни
            char[] letter = letters.ToCharArray(); // разбивам думите на отделни букви
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == 'A' || letter[i] == 'E' || letter[i] == 'I' || letter[i] == 'O' || letter[i] == 'U')
                {
                    sum += letter[i];
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(sum);
        }
    }

