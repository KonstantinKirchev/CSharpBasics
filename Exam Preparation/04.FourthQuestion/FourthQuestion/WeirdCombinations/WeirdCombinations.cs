using System;

    class WeirdCombinations
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int targetCount = int.Parse(Console.ReadLine());
            int count = 0;
            bool resultFound = false;
            for (int a = 0; a < input.Length; a++) // в тези 5 цикъла извъртам всички възможни комбинации от зададените ми символи
            {
                for (int b = 0; b < input.Length; b++)
                {
                    for (int c = 0; c < input.Length; c++)
                    {
                        for (int d = 0; d < input.Length; d++)
                        {
                            for (int e = 0; e < input.Length; e++)
                            {
                                if (count == targetCount)
                                {
                                    string output = "" + input[a] + input[b] + input[c] + input[d] + input[e];
                                    Console.WriteLine(output);
                                    resultFound = true;
                                }
                                    count++; // този каунтър започва от нула и при всеки следващ цикъл ще нараства докато стигне до желаната позиция и тогава ще влезе в if
                                // този каунтър задължително трябва да е след if. Ако беше преди if щеше да почне от 2рата комбинация, а не от първата и щеше да изкара
                                // като резултат една позици след желаната.!!!
                            }
                        }
                    }
                }
            }
            if (!resultFound)
            {
                Console.WriteLine("No");
            }
        }
    }

