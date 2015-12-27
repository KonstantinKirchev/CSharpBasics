using System;

class BitsUp
{
    static void Main()
    {
        uint countBaits = uint.Parse(Console.ReadLine());
        uint step = uint.Parse(Console.ReadLine());
        uint initial = step; // Правя си нова променлива която да ми пази стъпката
        step = 1; // а стъпката я приравнявам на 1ца, защото винаги почвам от 1вия бит от ляво на дясно.
        for (int i = 0; i < countBaits; i++)
        {
            uint numbers = uint.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--) // цикъла ми е от 7 към 0, защото броя от ляво на дясно
            {

                if (step == 0)
                {
                    numbers |= (uint)1 << bit; // с първата итерация сменям 1вия бит. 
                    step = initial; // стъпката си взема своята зададена стойност и в следващите итерации ще намалява всеки път с 1ца, докато стигне пак до 0, за да влезе в if-а и да смени съответния бит на съответната стъпка.
                }
                step--; // стъпката я намалявам с 1ца, за да ми е равна на 0 и да влезе в if-а.
            }
            Console.WriteLine(numbers);
        }
    }
}

