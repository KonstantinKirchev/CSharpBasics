using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object sumTwoWords = firstWord + " " + secondWord;
            string sumObject = (string)sumTwoWords;
            Console.WriteLine(sumObject);
        }
    }

