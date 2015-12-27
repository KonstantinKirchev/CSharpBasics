using System;
using System.Text.RegularExpressions;

    class LettersSymbolsNumbers
    {
        static void Main()
        {
            uint count = uint.Parse(Console.ReadLine());
            int letterNumber = 0;
            int numbers = 0;
            int symbols = 0;
            int sumLetters = 0;
            int sumNumbers = 0;
            int sumSymbols = 0;
            for (int j = 0; j < count; j++)
            {
                string[] letters = Console.ReadLine()
                                    .ToUpper()
                                    .Split(new string[] { "" }, StringSplitOptions.RemoveEmptyEntries); // цепя стринга и премахвам празните пространства от двете страни           
                string letterss = string.Join("", letters); // после ги събирам стринговете един до друг
                letterss = Regex.Replace(letterss, "\\s+", ""); // това премахва празните места и залепя символите
                char[] letter = letterss.ToCharArray(); // цепя стринга на отделни чарове в масив
                for (int i = 0; i < letter.Length; i++) // обхождам целия масив от чарове и пресмятам сумата на всички символи
                {
                    if (letter[i] == 'A' || letter[i] == 'B' || letter[i] == 'C' || letter[i] == 'D' || letter[i] == 'E' || letter[i] == 'F' || letter[i] == 'G' || letter[i] == 'H' || letter[i] == 'I'
                    || letter[i] == 'J' || letter[i] == 'K' || letter[i] == 'L' || letter[i] == 'M' || letter[i] == 'N' || letter[i] == 'O' || letter[i] == 'P' || letter[i] == 'Q'
                    || letter[i] == 'R' || letter[i] == 'S' || letter[i] == 'T' || letter[i] == 'U' || letter[i] == 'V' || letter[i] == 'W' || letter[i] == 'X' || letter[i] == 'Y' || letter[i] == 'Z')
                    {
                        letterNumber = (letter[i] - 64) * 10;
                        sumLetters += letterNumber;
                    }
                    else if (letter[i] == '0' || letter[i] == '1' || letter[i] == '2' || letter[i] == '3' || letter[i] == '4' || letter[i] == '5'
                     || letter[i] == '6' || letter[i] == '7' || letter[i] == '8' || letter[i] == '9')
                    {
                        numbers = (letter[i] - 48) * 20;
                        sumNumbers += numbers;
                    }
                    else 
                    {
                        if (letter[i]== ' ') // така пропускам празните места, за да не ми ги добави към сумата
                        {
                            continue;
                        }
                        symbols = 200;
                        sumSymbols += symbols;
                    }                   
                }
            }
            Console.WriteLine(sumLetters);
            Console.WriteLine(sumNumbers);
            Console.WriteLine(sumSymbols);
        }
    }

