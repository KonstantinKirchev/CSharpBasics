using System;

class ProgrammerDNA
{
    static char GetNextLetter(char letter)
    {
        letter++;
        if (letter > 'G')
        {
            letter = 'A';
        }
        return letter;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        for (int i = 1, count = 1; i <= n; count++, i++)
        {
            if (count == 8)
            {
                count = 1;
            }
            switch (count)
            {
                case 1:
                    Console.WriteLine(new string('.', 3)
                                    + new string(letter, 1)
                                    + new string('.', 3));
                    letter = GetNextLetter(letter);
                    break;
                case 2:
                    Console.Write(new string('.', 2));
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string('.', 2));
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write(new string('.', 1));
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string('.', 1));
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write(new string('.', 1));
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string('.', 1));
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Write(new string('.', 2));
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string(letter, 1));
                    letter = GetNextLetter(letter);
                    Console.Write(new string('.', 2));
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine(new string('.', 3)
                                    + new string(letter, 1)
                                    + new string('.', 3));
                    letter = GetNextLetter(letter);
                    break;
            }
        }
        //int totalLength = int.Parse(Console.ReadLine());
        //char printChar = char.Parse(Console.ReadLine());

        //char spaceChar = '.';

        //int blockSize = 7;
        //int midPoint = blockSize / 2;
        //int diff = 0;
        //int diffCounter = 0;

        //for (int counter = 0; counter < totalLength; counter++)
        //{
        //    // Print Block
        //    for (int i = 0; i < blockSize; i++)
        //    {
        //        if (i >= midPoint - diff && i <= midPoint + diff)
        //        {
        //            Console.Write(printChar);

        //            // Change Letter
        //            if (printChar == 'G')
        //            {
        //                printChar = 'A';
        //            }
        //            else
        //            {
        //                printChar++;
        //            }
        //        }
        //        else
        //        {
        //            Console.Write(spaceChar);
        //        }
        //    }

        //    if (diffCounter >= midPoint)
        //    {
        //        diff--;
        //    }
        //    else
        //    {
        //        diff++;
        //    }

        //    diffCounter++;

        //    if (diffCounter == blockSize)
        //    {
        //        diffCounter = 0;
        //        diff++;
        //    }

        //    Console.WriteLine();
        //}
    }
}






