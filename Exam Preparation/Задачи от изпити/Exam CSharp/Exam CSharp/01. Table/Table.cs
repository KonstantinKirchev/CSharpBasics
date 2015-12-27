using System;

class Table
{
    static void Main()
    {
        //input 
        long allLegs = 0;

        for (int i = 1; i < 5; i++)
        {
            allLegs += (long.Parse(Console.ReadLine()) * i);
        }

        long tableTops = long.Parse(Console.ReadLine());
        long neededTables = long.Parse(Console.ReadLine());

        long madedTables = Math.Min((allLegs / 4), tableTops);

        if (madedTables < neededTables)
        {
            long topNeeded = neededTables >= madedTables ? neededTables - madedTables : 0;
            long legsNeeded = neededTables * 4 >= allLegs ? neededTables * 4 - allLegs : 0;
            Console.WriteLine("less: {0}", madedTables - neededTables);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topNeeded, legsNeeded);
        }
        else if (neededTables < madedTables)
        {
            tableTops -= neededTables;
            allLegs -= (neededTables * 4);
            Console.WriteLine("more: {0}", madedTables - neededTables);
            Console.WriteLine("tops left: {0}, legs left: {1}", tableTops, allLegs);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", madedTables);
        }

        //output

    }
}
