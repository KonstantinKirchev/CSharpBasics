using System;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int currentPosition = 6;  // Това е позицията от която почвам, защото вземам битовете от ляво на дясно
        int numberOfBits = 0;
        int resultingNumber = 0;  // Създавам си ново число което е нула и на всяка итерация в цикъла ще го пълня с взетите битове       

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            while (currentPosition >= 0)
            {
                int currentBit = (currentNumber >> currentPosition) & 1;
                resultingNumber = (resultingNumber << 1) | currentBit;  // Тук пълня числото което ще принтирам на края с 0 и 1 
                numberOfBits++;  // каунта за битовете първоначално е 0 и нараства с всяко запълнено число 
                currentPosition -= step; // със стъпката отивам на следващият бит който трябва да взема
                // When a byte is completed, print it 
                // reset the number of bits and resulting number variables 
                if (numberOfBits == 8) // ако броят битове е 8 принтирам числото
                {
                    Console.WriteLine(resultingNumber);
                    resultingNumber = 0; // нулирам номера за да продължа нататъка с новото число
                    numberOfBits = 0; // и съответно нулирам битовете на новото число
                }
            }
            // If the loop is at the last step and there are bits left over 
            if (numberOfBits != 0 && i == n - 1)
            {
                resultingNumber = resultingNumber << (8 - numberOfBits);
                Console.WriteLine(resultingNumber);
            }
            currentPosition += 8;
        }
    }
}

//int n = int.Parse(Console.ReadLine());
//int step = int.Parse(Console.ReadLine());

//int index = 0;
//int outputBits = 0;
//int outputBitsCount = 0;
//for (int i = 0; i < n; i++)
//{
//    int num = int.Parse(Console.ReadLine());
//    for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
//    {
//        if ((index % step == 1) || (step == 1 && index > 0))
//        {
//            int bitValue = (num >> bitIndex) & 1;
//            // Console.WriteLine("bit : " + bitValue);
//            outputBits = outputBits << 1;
//            outputBits = outputBits | bitValue;
//            outputBitsCount++;
//            if (outputBitsCount == 8)
//            {
//                // We have 8 bits (1 byte) --> flush it to the output
//                Console.WriteLine(outputBits);
//                outputBits = 0;
//                outputBitsCount = 0;
//            }
//        }
//        index++;
//    }
//}

//if (outputBitsCount > 0)
//{
//    // We have a few bits left --> add trailing zeroes and flush them to the output
//    outputBits = outputBits << (8 - outputBitsCount);
//    Console.WriteLine(outputBits);
//}




//uint countBaits = uint.Parse(Console.ReadLine());
//uint step = uint.Parse(Console.ReadLine());
//uint initial = step; // Правя си нова променлива която да ми пази стъпката
//step = 2; // а стъпката я приравнявам на 2ка, защото винаги почвам от 1вия бит от ляво на дясно.
//uint bits = 0;
//string bitsAsString = "";
//for (int i = 0; i < countBaits; i++)
//{
//    uint numbers = uint.Parse(Console.ReadLine());
//    for (int bit = 7; bit >= 0; bit--) // цикъла ми е от 7 към 0, защото броя от ляво на дясно
//    {
//        step--; // стъпката я намалявам с 1ца, за да ми е равна на 0 и да влезе в if-а.
//        if (step == 0)
//        {
//            bits = (numbers>>bit) & (uint)1;
//            //Console.WriteLine(Convert.ToString(bits,2));
//            bitsAsString += bits;
//            bitsAsString = bitsAsString.PadRight(7, '0');
//            //numbers |= (uint)1 << bit; // с първата итерация сменям 1вия бит. 
//            step = initial; // стъпката си взема своята зададена стойност и в следващите итерации ще намалява всеки път с 1ца, докато стигне пак до 0, за да влезе в if-а и да смени съответния бит на съответната стъпка.
//        }

//    }

//    //Console.WriteLine(numbers);
//}

//uint bitsAsString1 = Convert.ToUInt32(bitsAsString, 2);
////Console.WriteLine(bitsAsString);
//Console.WriteLine(bitsAsString1);
//Main();




//int count = int.Parse(Console.ReadLine());
//int step = int.Parse(Console.ReadLine());
//string numbers = "";
//string currentLine = "";
//for (int i = 0; i < count; i++)
//{
//    int number = int.Parse(Console.ReadLine());
//    numbers += Convert.ToString(number, 2).PadLeft(8, '0');
//}
//string resultBinary = "";
//int position = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    position = 1 + i * step;
//    if (position >= numbers.Length)
//    {
//        break;
//    }
//    resultBinary += numbers[position];
//}
//int length = resultBinary.Length % 8;
//int pading = 8 - length;

//if (resultBinary.Length < 8)
//{
//    string a = resultBinary.PadRight(8, '0');
//    Console.WriteLine(Convert.ToInt64(a, 2));
//}
//else
//{

//    for (int i = 0; i <resultBinary.Length +length ; i++)
//    {
//        if (i < resultBinary.Length )
//        {
//            currentLine += resultBinary[i];
//            if (currentLine.Length == 8)
//            {
//                Console.WriteLine(Convert.ToInt64(currentLine, 2));
//                currentLine = "";
//            }
//        }
//        else
//        {
//            currentLine += "0";
//            if (currentLine.Length % 8 == 0)
//            {
//                Console.WriteLine(Convert.ToInt64(currentLine,2));
//                currentLine = "";
//            }
//        }

//    }
//}
//    }
//}

