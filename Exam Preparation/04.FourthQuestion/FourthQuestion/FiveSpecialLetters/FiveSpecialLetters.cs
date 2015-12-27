using System;
using System.Collections.Generic;

    class FiveSpecialLetters
    {
        static void Main()
        {
            Dictionary<char, int> lettersWeight = new Dictionary<char, int>    
            {
                
            {'a',  5},
            {'b',-12},
            {'c', 47},
            {'d',  7},
            {'e',-32}
            
            };
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int resultCount = 0;
            long weight = 0;
            for (char i = 'a'; i <= 'e'; i++)
            {
                for (char j = 'a'; j <= 'e'; j++)
                {
                    for (char k = 'a'; k <= 'e'; k++)
                    {
                        for (char l = 'a'; l <= 'e'; l++)
                        {
                            for (char h = 'a'; h <= 'e'; h++)
                            {
                                if (h == l || h == k || h == j || h == i || l == k || l == j || l == i || k == j || k == i || j == i)
                                {
                                    continue;
                                }
                                weight = 1 * lettersWeight[i] + 2 * lettersWeight[j] + 3 * lettersWeight[k] + 4 * lettersWeight[l] + 5 * lettersWeight[h];
                                if (weight >= start && weight <= end)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, k, l, h);
                                    resultCount++;
                                }

                            }
                        }
                    }
                }
            }
            if (resultCount == 0)
            {
                Console.WriteLine("No");
            }
        }
    //    long minWeight = long.Parse(Console.ReadLine());
    //    long maxWeight = long.Parse(Console.ReadLine());

    //    int resultsCount = 0;
    //    for (char c1 = 'a'; c1 <= 'e'; c1++)
    //    {
    //        for (char c2 = 'a'; c2 <= 'e'; c2++)
    //        {
    //            for (char c3 = 'a'; c3 <= 'e'; c3++)
    //            {
    //                for (char c4 = 'a'; c4 <= 'e'; c4++)
    //                {
    //                    for (char c5 = 'a'; c5 <= 'e'; c5++)
    //                    {
    //                        string word = "" + c1 + c2 + c3 + c4 + c5;
    //                        long weight = CalcWeight(word);
    //                        //Console.WriteLine(word + " " + weight);
    //                        if (weight >= minWeight && weight <= maxWeight)
    //                        {
    //                            if (resultsCount > 0)
    //                            {
    //                                Console.Write(" ");
    //                            }
    //                            Console.Write(word);
    //                            resultsCount++;
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    if (resultsCount == 0)
    //    {
    //        Console.Write("No");
    //    }
    //}

    //static long CalcWeight(string word)
    //{
    //    bool[] used = new bool[(int)'e' + 1];
    //    long weight = 0;
    //    int index = 1;
    //    for (int i = 0; i < word.Length; i++)
    //    {
    //        char letter = word[i];
    //        if (!used[letter])
    //        {
    //            weight += index * CalcWeight(letter);
    //            index++;
    //            used[letter] = true;
    //        }
    //    }
    //    return weight;
    //}

    //static int CalcWeight(char letter)
    //{
    //    switch (letter)
    //    {
    //        case 'a': return 5;
    //        case 'b': return -12;
    //        case 'c': return 47;
    //        case 'd': return 7;
    //        case 'e': return -32;
    //    }
    //    return 0;
    //}
    }

