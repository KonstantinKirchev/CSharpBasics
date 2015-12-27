using System;

class DoubleDowns
{
    static void PrintAsBit(int n)
    {
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(9, '0'));
    }
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        //PrintAsBit(n);
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //logic
        int verticalCount = 0; // по условие се търси броя на вертикалните засичания на 1 с 1
        int leftCount = 0; // съответно по левия диагонал
        int rightCount = 0; // и десния диагонал

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            //int number1 = numbers[i];
            //int number2 = numbers[i + 1];
            int vertical = numbers[i] & numbers[i + 1]; // двете числа са едно под друго и с оператора & в променливата vertical остават само засечените 1ци
            verticalCount += CountBitOne(vertical); // Тук си викам метода който ми отброява колко 1ци има в vertical

            int left = (numbers[i] << 1) & numbers[i + 1]; // тук правя същото както преди само измествам 1вото число с една позиция на ляво
            leftCount += CountBitOne(left);

            int right = (numbers[i] >> 1) & numbers[i + 1]; // тук правя същото както преди само измествам 1вото число с една позиция на дясно
            rightCount += CountBitOne(right);
        }

        //output

        Console.WriteLine(rightCount);
        Console.WriteLine(leftCount);
        Console.WriteLine(verticalCount);

    }
    static int CountBitOne(int number)
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
    }
}
   