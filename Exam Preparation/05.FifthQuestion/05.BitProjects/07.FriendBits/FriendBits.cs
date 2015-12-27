using System;

    class FriendBits
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            string friends = "0"; // инициализирам променлива за едните и другите битове
            string alones = "0";

            string bitString = Convert.ToString(n, 2).PadLeft(32, '0'); // обръщам чилото в стринг от 0 и 1

            char lastChar = bitString[0]; // последния чар ми е най-левият бит в стринга!!! Него не го пипам
            int count = 1; 
            for (int i = 1; i < bitString.Length; i++) // почвам да минавам по стринга от битове от следващият чар 1
            {
                if (lastChar == bitString[i]) // ако двата съседни чара са равни отброявам 
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        friends += new String(lastChar, count); // така записвам каунт на брой пъти еднаквите 0 или 1
                    }
                    else
                    {
                        alones += lastChar; // ако нямам поредни еднакви ги записвам тук
                    }
                    count = 1; // каунта задължително го приравнявам на единица, за да почне да брой от начало
                }
                lastChar = bitString[i]; // и записвам последния чар с който съм работил, за да бъде сравняван в следваща итерация с следващото число
            }
            if (count > 1)
            {
                friends += new String(lastChar, count); // тука записвам вече събраните последователности от 0 и 1 в един общ стринг 
            }
            else
            {
                alones += lastChar; // същото правя и за самотните 0 и 1
            }
            Console.WriteLine(Convert.ToUInt32(friends, 2)); // тука ги обръщам в числа и ги отпечатвам
            Console.WriteLine(Convert.ToUInt32(alones, 2));
            //uint n = uint.Parse(Console.ReadLine());
            //uint friendBits = 0;
            //uint aloneBits = 0;
            //for (int i = 31; i >= 0; i--)
            //{
            //    uint currentBit = (n >> i) & 1;

            //    bool hasLeftBit = (i < 31);
            //    uint leftBit = (n >> (i + 1)) & 1;
            //    bool sameLeftBit = hasLeftBit && (leftBit == currentBit);

            //    bool hasRightBit = (i > 0);
            //    uint rightBit = (n >> (i - 1)) & 1;
            //    bool sameRightBit = hasRightBit && (rightBit == currentBit);

            //    bool friendBit = sameLeftBit || sameRightBit;
            //    if (friendBit)
            //    {
            //        friendBits = (friendBits << 1) | currentBit;
            //    }
            //    else
            //    {
            //        aloneBits = (aloneBits << 1) | currentBit;
            //    }
            //}
            //Console.WriteLine(friendBits);
            //Console.WriteLine(aloneBits);

         uint input = uint.Parse(Console.ReadLine());   
         uint friendBits = 0; 
         uint aloneBits = 0; 
         int leftmostBit = 0; 
         uint temp = input; 
         while (temp > 0) 
         { 
             temp >>= 1; 
             leftmostBit++; 
         } 
         uint previousBit = 0; 
         uint currentBit = 0; 
         uint nextBit = 0; 
         while (leftmostBit > 1) 
         { 
             nextBit = (input >> leftmostBit - 2) & 1;             
             currentBit = (input >> leftmostBit - 1) & 1; 
             if (currentBit == nextBit) 
             { 
                 friendBits <<= 1; 
                 friendBits |= currentBit; 
             } 
             else if (currentBit == previousBit) 
             { 
                 friendBits <<= 1; 
                 friendBits |= currentBit; 
             } 
             else 
             { 
                 aloneBits <<= 1; 
                 aloneBits |= currentBit; 
             } 
             previousBit = currentBit; 
             leftmostBit--;            
         } 
         uint firstBit = input & 1; 
         if (firstBit == previousBit) 
         { 
             friendBits <<= 1; 
             friendBits |= firstBit; 
         } 
         else 
         { 
             aloneBits <<= 1; 
             aloneBits |= firstBit; 
         } 
         Console.WriteLine(friendBits); 
         Console.WriteLine(aloneBits); 
        }
    }
  

