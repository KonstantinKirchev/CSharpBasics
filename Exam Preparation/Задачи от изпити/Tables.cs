using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long T = long.Parse(Console.ReadLine());
        long N = long.Parse(Console.ReadLine());

        long allLegs = 1 * bundle1 + 2 * bundle2 + 3 * bundle3 + 4 * bundle4;
        long topsRest = T - N;
        long legsRest = allLegs - (4 * N);
        long addTable = topsRest * 4;

        if (T < N)
        {
            Console.WriteLine("less: {0}", topsRest);
            Console.Write("tops needed: {0}, ", topsRest * (-1));
            if (legsRest < 0)
            {
                Console.WriteLine("legs needed: {0}", legsRest * (-1));
            }
            else
            {
                Console.WriteLine("legs needed: {0}", 0);
            }
        }
        else if (T > N)
        {
            if ((topsRest * 4) <= legsRest)
            {
                Console.WriteLine("more: {0}", topsRest);
                Console.WriteLine("tops left: {0}, legs left: {1}", topsRest, legsRest);
            }
            else if (legsRest == 0)
            {
                Console.WriteLine("Just enough tables made: {0}", N);
            }
        }
        else if (T == N)
        {
            if (legsRest >= 0)
            {
                Console.WriteLine("Just enough tables made: {0}", N);
            }
        }
    }
}
