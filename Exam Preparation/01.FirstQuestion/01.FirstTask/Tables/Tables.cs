using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToBeMade = long.Parse(Console.ReadLine());

        long allLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4); // така намирам всички крака с които разполагам
        long tablesMade = Math.Min((allLegs / 4), tableTops); // така намирам по-малкото от двете (крака и топове), за да намеря колко маси могат да се направят

        if (tablesMade > tablesToBeMade)
        {
            long topsLeft = tableTops - tablesToBeMade; // така намирам колко топа остават, защото за всяка маса е нужен 1 топ
            long legsLeft = allLegs - tablesToBeMade * 4; // така намирам останалите крака, като от общият брои извада използваните крака за направа на зададените маси
            Console.WriteLine("more: {0}", tablesMade - tablesToBeMade); // тук намирам колко още маси могат да се направят
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }
        else if (tablesMade < tablesToBeMade)
        {
            long topsNeedd = tablesToBeMade >= tableTops ? tablesToBeMade - tableTops : 0; // чрез тернарният оператор проверявам ако масите които трябва да бъдат направени са повече или равни от топовете, тогава от масите които трябва да бъдат направени вадя топовете.Ако не е изпълнено това условие изписвам 0.
            long legsNeeded = tablesToBeMade * 4 >= allLegs ? tablesToBeMade * 4 - allLegs : 0; // тук правя същото както горе, но за необходимите крака
            Console.WriteLine("less: {0}", tablesMade - tablesToBeMade); // тук намирам колко маси няма да бъдат направени, поради недостиг на материали
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeedd, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
    }
}
