using System;

    class BitRoller
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int rollTimes = int.Parse(Console.ReadLine());
            int frozenBit = (number >> position) & 1;
            int mask = 0;
            if (position != 0)
            {
                string str = new string('1', position); // правя си стринг от 1ци за да запазя десните битове
                mask = Convert.ToInt32(str, 2); // после стринга от единици го превръщам в интова маска
            }        
            int rightBits = number & mask; // save bits to the right of position for later use
            int leftBits = number >> (position + 1);
            number = (leftBits << position) | rightBits;          
            int bit = 0;
            for (int i = 0; i < rollTimes; i++) // този цикъл върти 0левия бит го прави старши
            {
                bit = number & 1;
                number = number >> 1;
                number |= (bit << 17);       
            }
            int mask2 = 0;
            if (position != 0)
            {
                string str2 = new string('1', position); // правя си стринг от 1ци за да запазя десните битове
                mask2 = Convert.ToInt32(str2, 2); // после стринга от единици го превръщам в интова маска
            }         
            int rightBits2 = number & mask2; // save bits to the right of position for later use
            number = number >> position; // измествам числото на дясно за да запазя само лявата част (дясната се нулира)
            number = number << (position + 1); // връщам числото на ляво с една позиция повече. Така си освобождавам място за да вмъкна бит
            number |= frozenBit << position; // закарвам 1ца бит на освободената вече позиция   
            number = number | rightBits2; // добавям към левите битове и 1цата останалите десни битове         
            Console.WriteLine(number);
        }
    }

