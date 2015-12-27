using System;
class BitPaths
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] moves = new int[8];

        for (int i = 0; i < n; i++)
        {
            string[] move = Console.ReadLine().Split(',');

            int way = 0;
            int curMove = 0;
            for (int c = 0; c < moves.Length; c++)
            {
                curMove = int.Parse(move[c]);
                if (c == 0)
                {
                    way = 3 - curMove;
                }
                else
                {
                    if (curMove == 0)
                    {
                        way += 0;
                    }
                    else if (curMove > 0)
                    {
                        way--;
                    }
                    else
                    {
                        way++;
                    }
                }
                moves[c] = moves[c] ^ (1 << way);
            }
        }

        int sum = 0;
        foreach (var item in moves)
        {
            sum += item;
        }
        PrintAsBit(sum);
        string hex = sum.ToString("X").ToUpper();
        Console.WriteLine("{0}", hex);
    }
    private static void PrintAsBit(int input)
    {
        Console.WriteLine(Convert.ToString(input, 2));
    }
}