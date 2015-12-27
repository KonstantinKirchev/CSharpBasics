using System;


class OddAndEvenJumps
{
    static void Main()
    {
        string[] input = Console.ReadLine().ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        string processedInput = string.Join("", input);
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        long oddResult = 0;
        long evenResult = 0;
        int currentJumpPos = 1; // защото това е първият символ в редицата от който се почва
       
        // Odd characters
        for (int i = 0; i < processedInput.Length; i+=2) // минавам по нечетните символи
        {
            long currentSymbolCode = (long)processedInput[i];
            if (currentJumpPos == oddJump) // ако позицията е равна на скока влиза
            {
                oddResult *= currentSymbolCode;
                currentJumpPos = 1; // тук нулирам позицията
            }
            else 
            {
                oddResult += currentSymbolCode;
                currentJumpPos++; // след всяко събиране на символите позицията се увеличава с единица
            }
        }

        currentJumpPos = 1;
        // Even characters
        for (int i = 1; i < processedInput.Length; i += 2) // тук правя същото за четните символи
        {
            long currentSymbolCode = (long)processedInput[i];
            if (currentJumpPos == evenJump)
            {
                evenResult *= currentSymbolCode;
                currentJumpPos = 1;
            }
            else
            {
                evenResult += currentSymbolCode;
                currentJumpPos++;
            }
        }

        Console.WriteLine("Odd: {0:X}", oddResult); // тук отпечатвам резултата в шеснайсетично изражение
        Console.WriteLine("Even: {0:X}", evenResult);
//        string input = Console.ReadLine();
//        int oddJump = int.Parse(Console.ReadLine());
//        int evenJump = int.Parse(Console.ReadLine());

//        input = input.Replace(" ", string.Empty).ToLower();

//        long oddSum = 0;
//        int oddCount = 1;
//        long evenSum = 0;
//        int evenCount = 1;

//        for (int i = 0; i < input.Length; i++)
//        {
//            if (i % 2 == 0) //Odd letter
//            {
//                if (oddCount % oddJump != 0) 
//                {
//                    oddSum += input[i];
//                }
//                else
//                {
//                    oddSum *= input[i];
//                }
//                oddCount++;
//            }
//            else //Even letter
//            {
//                if (evenCount % evenJump != 0) 
//                {
//                    evenSum += input[i];
//                }
//                else
//                {
//                    evenSum *= input[i];
//                }
//                evenCount++;
//            }
//        }

//        Console.WriteLine("Odd: {0:X}", oddSum);
//        Console.WriteLine("Even: {0:X}", evenSum);
//    }
//}
    }
}

