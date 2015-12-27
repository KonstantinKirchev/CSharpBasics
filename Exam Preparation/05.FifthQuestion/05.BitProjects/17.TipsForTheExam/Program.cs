using System;

    class Program
    {
        static void Main()
        {
            I.
                static void PrintAsBit(int n)
                {
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                }
            II.
                static int CountBitOne(int number) // този метод ми отброява само 1ците (без 0лите)
                {
                int counter = 0;

                while (number != 0)
                {
                    /*
                    * In this way we working at binary notation. When use '-' at binary notation we extracting ones. 
                    * Example: 5 - 1 = 4 in binary is like this:
                    *   0101 | Then we using bitwise operator '&' to remove ones thats not need anymore.
                    * - 0001 | If you don't use '&' your while never stop becouse you have only one operation.
                    * -------| At the example we have 5 so number will be equal to 4 and 4 != 0 and will never be equal with zero.
                    *   0100 | Be carefully when working with bitwise operations. When we use '&' we changing value of number integer.
                    *   Use workbook and work with binary notation to get more experience
                    */
                    int diff = number - 1;
                    number = number & diff;
                    counter++;
                }
                return counter;
           III.
                 public static int getBitsCount(int number) // този метод ми отброява всички битове
                 { 
                     int count = 0;        
 

                     while (number > 0) 
                     { 
                         count++; 
                         number = number >> 1; 
                     } 
 

                     return Math.Max(1, count); 
                 } 

           III.
                static ulong GetBitAtPosition(ulong number, int position)
                {
                    ulong nRightP = number >> position;
                    ulong bit = nRightP & 1;
                    return bit;
                }
        IV.
                static ulong SetBitToZero(ulong number, int position)
                {
                    ulong mask = (ulong)(~(1 << position));
                    ulong result = number & mask;
                    return result;
                }
        V.
                static ulong SetBitToOne(ulong number, int position)
                {
                    ulong mask = (ulong)(1 << position);
                    ulong result = number | mask;
                    return result;
                }
         VI.
                    case "flip":
                        number ^= 1 << position; // сменям бита на съответната позиция без да се интересувам какъв е (0 или 1) с ^ - този оператор ги обръща
             
                    case "insert":
                        number = number >> position; // измествам числото на дясно за да запазя само лявата част (дясната се нулира)
                       
                        number = number << (position + 1); // връщам числото на ляво с една позиция повече. Така си освобождавам място за да вмъкна бит

                        long mask2 = ((long)1 << position); // закарвам 1ца бит на освободената вече позиция
                        
                        number = number | mask2; // вкарвам 1ца бит на освободената вече позиция

                        number = number | rightBits; // добавям към левите битове и 1цата останалите десни битове
             
                    case "remove":
                        number = number >> (position + 1); // премествам числото с една позиция повече за да премахна числото от дадената позиция 

                        number = number << position; // връщам числото на съответната позиция. То вече е без премахнатия бит.

                        number = number | rightBits; // добавям към левите битове останалите десни битове
    
            VII.
                    int[] numbers = new int[8]; // инициализирам си масив с 8 елемента, защото на входа ми подават винаги 8 числа
                    for (int i = 0; i < 8; i++)
                    {
                        numbers[i] = int.Parse(Console.ReadLine()); // С този цикъл си пълня масива с 8 числа
                    }
        }
    }

