using System;

    class BitBuilder
    {
        static void Main()
        {   
            long number = long.Parse(Console.ReadLine()); // Insert commands can cause overflow of int
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

            string order = Console.ReadLine();

            while (order != "quit")
            {
                int position = int.Parse(order);
                order = Console.ReadLine();

                long mask = 0L;

                if (position != 0) // позицията трябва да е различна от нула иначе нямам битове от дясно
                {
                    string str = new string('1', position); // правя си стринг от 1ци за да запазя десните битове
                    mask = Convert.ToInt64(str, 2); // после стринга от единици го превръщам в интова маска
                }

                long rightBits = number & mask; // save bits to the right of position for later use

                switch (order)
                {
                    case "flip":
                        number ^= 1 << position; // сменям бита на съответната позиция без да се интересувам какъв е (0 или 1) с ^ - този оператор ги обръща
                        //Console.WriteLine("number ^= 1 << position");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));
                        break;
                    case "insert":
                        number = number >> position; // измествам числото на дясно за да запазя само лявата част (дясната се нулира)
                        //Console.WriteLine("number = number >> position");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                        number = number << (position + 1); // връщам числото на ляво с една позиция повече. Така си освобождавам място за да вмъкна бит
                        //Console.WriteLine("number = number << (position + 1)");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                        long mask2 = ((long)1 << position); // закарвам 1ца бит на освободената вече позиция
                        //Console.WriteLine("mask 2 = ((long)1 << position)");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                        number = number | mask2; // вкарвам 1ца бит на освободената вече позиция
                        //Console.WriteLine("number = number | mask2");
                        //Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(64, '0'));

                        number = number | rightBits; // добавям към левите битове и 1цата останалите десни битове
                        //Console.WriteLine("number = number | rightBits");
                        //Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(64, '0'));
                        break;
                    case "remove":
                        number = number >> (position + 1); // премествам числото с една позиция повече за да премахна числото от дадената позиция 
                        //Console.WriteLine("number >> (position + 1)");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                        number = number << position; // връщам числото на съответната позиция. То вече е без премахнатия бит.
                        //Console.WriteLine(" number = number << position");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                        number = number | rightBits; // добавям към левите битове останалите десни битове
                        //Console.WriteLine("number = number | rightBits");
                        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));
                        break;
                }

                //Console.WriteLine("number after command");
                //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0'));

                order = Console.ReadLine(); // receive new order after first is executed. Тази стъпка е много важна, за да може цикъла да продължи. Програмата чака order!!!
            }

            Console.WriteLine(number);
           
        }
    }

