using System;

    class Program
    {
        static void Main()
        {
            double startNumber = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            double[,] matrix = new double[4,4];
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4;startNumber +=step, col++)
                {
                    matrix[row, col] = startNumber;
                    //Console.Write(matrix[row, col]);
                }
                //Console.WriteLine();
            }
            string order = Console.ReadLine();
            while (order != "Game Over!")
            {
                string[] input = order.Split();
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);
                string command = input[2];
                double num = double.Parse(input[3]);
                
                    switch (command)
                    {
                        case "multiply":
                            matrix[row, col] *= num;
                            break;
                        case "sum":
                            matrix[row, col] += num;
                            break;
                        case "power":
                            matrix[row, col] = Math.Pow(matrix[row, col],num);
                            break;
                    }
                
                order = Console.ReadLine();
            }
            double maxSum = double.MinValue;
            int index = 0;
            string maxType = "ROW";
            for (int row = 0; row < 4; row++)
            {
                double sum = matrix[row, 0] + matrix[row, 1] + matrix[row, 2] + matrix[row, 3];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = row;
                }
            }
            for (int col = 0; col < 4; col++)
            {
                double sum = matrix[0, col] + matrix[1, col] + matrix[2, col] + matrix[3, col];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = col;
                    maxType = "COLUMN";
                }
            }
            double leftDiagonalSum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
            if (leftDiagonalSum>maxSum)
            {
                maxSum = leftDiagonalSum;
                maxType = "LEFT-DIAGONAL";
            }
            double rightDiagonalSum = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];
            if (rightDiagonalSum > maxSum)
            {
                maxSum = rightDiagonalSum;
                maxType = "RIGHT-DIAGONAL";
            }
            if (maxType == "ROW" || maxType == "COLUMN")
            {
                Console.WriteLine("{0}[{1}] = {2:F2}",maxType, index, maxSum);
            }
            else
            {
                Console.WriteLine("{0}[{1}] = {2:F2}",maxType,maxSum);
            }

            //for (int row = 0; row < 4; row++)
            //{
            //    for (int col = 0; col < 4; col++)
            //    {
                    
            //        Console.Write(matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }

