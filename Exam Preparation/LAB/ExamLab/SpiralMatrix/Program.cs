using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int row = 0;
        int col = 0;
        int count = 0;
        int[,] matrix = new int[size, size]; // тук само си инициализирам матрицата
        while (count < size * size) // докато не запълним цялата матрица този цикъл ще продължава
        {
            while (col < size && matrix[row, col] == 0) // тръгвам надясно да пълня матрицата
            {
                count++;
                matrix[row, col] = count;
                col++;
            }
            col--;
            row++;
            while (row < size && matrix[row, col] == 0) // тръгвам надолу
            {
                count++;
                matrix[row, col] = count;
                row++;
            }
            row--;
            col--;
            while (col >= 0 && matrix[row, col] == 0) // тръгвам наляво
            {
                count++;
                matrix[row, col] = count;
                col--;
            }
            col++;
            row--;
            while (row >= 0 && matrix[row, col] == 0) // тръгвам нагоре
            {
                count++;
                matrix[row, col] = count;
                row--;
            }
            row++; // тук вече влизам във вътрешността на матрицата. До сега вървях по периферията!!!
            col++;
        }
        for (row = 0; row < size; row++) // с два вложени for цикъла си принтирам матрицата
        {
            for (col = 0; col < size; col++) // обърната матрица става като циклите за редове и колони започнат от size до 0 вклучително и row-- col-- !!!
            {
                Console.Write("{0,3} ",matrix[row,col]); // Write, защото принтирам ред по ред
            }
            Console.WriteLine(); // за да мина на нов ред след като съм запълнил 1вия ред
        }
    }
}

