using System;

    class SpiralMatrix
    {
        static void Main()
        {
            System.Console.SetWindowSize(100, 30);
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int value = 1;

            if (n > 0 && n < 21)
            {
                while (value <= n * n)
                {
                    while (col < matrix.GetLength(0) && matrix[col, row] == 0)
                    {
                        matrix[row, col++] = value;
                        value++;
                    }
                    col--;
                    row++;
                    while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                    {
                        matrix[row++, col] = value;
                        value++;
                    }
                    row--;
                    col--;
                    while (col >= 0 && matrix[row, col] == 0)
                    {
                        matrix[row, col--] = value;
                        value++;
                    }
                    col++;
                    row--;
                    while (row >= 0 && matrix[row, col] == 0)
                    {
                        matrix[row--, col] = value;
                        value++;
                    }
                    col++;
                    row++;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(j * 5, i * 2);
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("out of range");
            }

    //        Console.Write("N = ");

    //    int n = int.Parse(Console.ReadLine());

    //    int[,] matrix = new int[n, n];

 

    //    FillMatrix(matrix, n);

 

    //    PrintMatrix(matrix, n);

    //}

 

    //private static void FillMatrix(int[,] matrix, int n)

    //{

    //    int positionX = n / 2; // The middle of the matrix

    //    int positionY = n % 2 == 0 ? (n / 2) - 1 : (n / 2);

 

    //    int direction = 0; // The initial direction is "down"

    //    int stepsCount = 1; // Perform 1 step in current direction

    //    int stepPosition = 0; // 0 steps already performed

    //    int stepChange = 0; // Steps count changes after 2 steps

 

    //    for (int i = 0; i < n * n; i++)

    //    {

    //        // Fill the current cell with the current value

    //        matrix[positionY, positionX] = i;

 

    //        // Check for direction / step changes

    //        if (stepPosition < stepsCount)

    //        {

    //            stepPosition++;

    //        }

    //        else

    //        {

    //            stepPosition = 1;

    //            if (stepChange == 1)

    //            {

    //                stepsCount++;

    //            }

    //            stepChange = (stepChange + 1) % 2;

    //            direction = (direction + 1) % 4;

    //        }

 

    //        // Move to the next cell in the current direction

    //        switch (direction)

    //        {

    //            case 0:

    //                positionY++;

    //                break;

    //            case 1:

    //                positionX--;

    //                break;

    //            case 2:

    //                positionY--;

    //                break;

    //            case 3:

    //                positionX++;

    //                break;

    //        }

    //    }

    //}

 

    //private static void PrintMatrix(int[,] matrix, int n)

    //{

    //    for (int i = 0; i < n; i++)

    //    {

    //        for (int j = 0; j < n; j++)

    //        {

    //            Console.Write("{0,3}", matrix[i, j]);

    //        }

    //        Console.WriteLine();

    //    }

    }

}



