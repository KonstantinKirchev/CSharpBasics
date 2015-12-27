using System;

    class TelerikLogoMatrix
    {
        static void Main()
        {

            //int n = int.Parse(Console.ReadLine());
            //char dot = '.';
            //char asteriks = '*';
            //char[,] matrix = new char[(3 * n) - 2, (3 * n) - 2];
            ////for (int row = 0; row < (3 * n) - 2; row++)
            ////{
            ////    for (int col = 0; col < (3 * n) - 2; col++)
            ////    {
            ////        matrix[row, col] = dot;
            ////        if (matrix[row,col] == asteriks)
            ////        {
            ////            continue;
            ////        }
            ////        Console.Write(matrix[row, col]);
            ////    }
            ////    Console.WriteLine();
            ////}
            ////int n = int.Parse(Console.ReadLine());
            ////int[,] matrix = new int[n, n];

            //string direction = "up";

            //int currentRow = n / 2 + 1;
            //int currentCol = 1;
            //currentCol++;
            //currentRow--;
            //for (int i = 1; i <= (n / 2 + 1) + (n / 2 + 1) + 6 * n; i++) // тази матрица започва да пълни отвън на вътре. Обърната се прави като обърна for цикъла да започва от 100 до n*n и i--.
            //{
            //    matrix[currentRow, currentCol] = '*';
            //    if (direction == "up" && currentRow >= n / n)
            //    {
            //        currentCol++;
            //        currentRow++;
            //        direction = "down";
            //    }
            //    //else if (direction == "down" && currentRow >= (n * 2) - 1)
            //    //{
            //    //    currentRow++;
            //    //    currentCol--;

            //    //}
            //    //else if (direction == "down" && currentRow >= (3 * n) - 2)
            //    //{
            //    //    currentCol--;
            //    //    currentRow--;
            //    //    direction = "up";
            //    //}
            //    //else if (direction == "up" && currentRow >= (n * 2) - 1)
            //    //{
            //    //    currentRow--;
            //    //    currentCol--;
            //    //}
            //    //else if (direction == "up" && currentRow >= n / n)
            //    //{
            //    //    currentRow--;
            //    //    currentCol++;
            //    //}
                
            //}
            //// print matrix
            
            //for (int i = 0; i < (3 * n) - 2; i++)
            //{
            //    for (int j = 0; j < (3 * n) - 2; j++)
            //    {
            //        matrix[i, j] = dot;
                    
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}







            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            string direction = "right";

            int currentRow = 0;
            int currentCol = 0;
            for (int i = 1; i <= n * n; i++) // тази матрица започва да пълни отвън на вътре. Обърната се прави като обърна for цикъла да започва от 100 до n*n и i--.
            {
                if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow++;
                    direction = "down";
                }
                else if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol--;
                    direction = "left";
                }
                else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    currentRow--;
                    direction = "up";
                }
                else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    currentCol++;
                    direction = "right";
                }
                matrix[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }
            // print matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine();

            }
        }
    }

