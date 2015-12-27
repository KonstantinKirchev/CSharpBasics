using System;
using System.Linq;

    class BitPaths
    {
        static void PrintAsBit(int n)
        {
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(9, '0'));
        }

        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] board = new int[8];
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] currentPath = input.Split(','); // Тук имам масив от стрингове
                int[] path = new int[8]; // Този масив е празен в момента и в него ще пазя числа
                //int[] path = input.Split(',').Select(int.Parse).ToArray(); // Така директно си вземаме числата от масив от стрингове в масив от инт.
                //int[] path = Array.ConvertAll(input.Split(','), element => int.Parse(element)); // Това е 3ти начин да си напилня един инт масив с числа от стринг масив.
                for (int j = 0; j < 8; j++)
                {
                    path[j] = int.Parse(currentPath[j]); // Така си пълня празния масив от инт с числа
                }
                int position = 3 - path[0]; // Тук обръщам позицията за да работя от дясно на ляво(както е при битовете), а не както е показано от ляво на дясно(както е при стринговете)
                for (int k = 0; k < 8; k++)
                {
                    board[k] ^= (1 << position);
                    if (k==7)
                    {
                        break;
                    }
                    position -= path[k+1]; // Тук променям позицията спрямо пътя който ми е зададен.Ако ми е дадено -1 то аз отивам на +1 и обратно.
                }
                
            }
            int sum = board.Sum();
            Console.WriteLine(Convert.ToString(sum,2)); // Така принтирам числото в битове (бинарен вид)
            Console.WriteLine("{0:X}",sum); // Така принтирам числото в шестнайсетична бройна система.Трябва да внимавам с (x или X) малки или големи букви!!! 
        }
    }

