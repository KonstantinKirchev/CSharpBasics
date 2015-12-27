using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class CrossingSequences
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());
        int spiralStart = int.Parse(Console.ReadLine());
        int spiralStep = int.Parse(Console.ReadLine());

        if (spiralStart == numberOne)
        {
            Console.WriteLine(spiralStart);
            Environment.Exit(0);
        }
        else if (spiralStart == numberTwo)
        {
            Console.WriteLine(spiralStart);
            Environment.Exit(0);
        }
        else if (spiralStart == numberThree)
        {
            Console.WriteLine(spiralStart);
            Environment.Exit(0);
        }

        int result = 0;
        int counter = 0;
        int index = spiralStep;
        List<int> tribonacciList = new List<int>();
        tribonacciList.Add(numberOne);
        tribonacciList.Add(numberTwo);
        tribonacciList.Add(numberThree);
        List<int> spiralList = new List<int>();
        for (int i = spiralStep, j = 4; ; i += index, j++)
        {
            counter++;
            if (counter != 0 && counter % 2 == 0)
            {
                index += spiralStep;
            }
            if (numberThree > 1000000 && spiralStart + i > 1000000)
            {
                break;
            }
            result = numberOne + numberTwo + numberThree;
            numberOne = numberTwo;
            numberTwo = numberThree;
            numberThree = result;
            tribonacciList.Add(numberThree);
            spiralList.Add(spiralStart + i);
        }

        bool isFound = false;
        var intersect = tribonacciList.Intersect(spiralList);
        foreach (int value in intersect)
        {
            if (value > 1000000)
            {
                break;
            }
            isFound = true;
            Console.WriteLine(value);
        }
        if (isFound == false)
        {
            Console.WriteLine("No");
        }
    }
}