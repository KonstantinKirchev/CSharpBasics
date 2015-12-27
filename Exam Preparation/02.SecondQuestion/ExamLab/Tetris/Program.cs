using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main()
        {
            string[] size = Console.ReadLine().Split(' ');
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                char[] chars = line.ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            int i = 0, l = 0, j = 0, o = 0, z = 0, s = 0, t = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    i += GetFigure(matrix, row, col, row + 1, col, row + 2, col, row + 3, col);
                    l += GetFigure(matrix, row, col, row + 1, col, row + 2, col, row + 2, col + 1);
                    j += GetFigure(matrix, row, col, row + 1, col, row + 2, col, row + 2, col - 1);
                    o += GetFigure(matrix, row, col, row + 1, col, row + 1, col + 1, row, col + 1);
                    z += GetFigure(matrix, row, col, row, col + 1, row + 1, col + 1, row + 1, col + 2);
                    s += GetFigure(matrix, row, col, row, col + 1, row - 1, col + 1, row - 1, col + 2);
                    t += GetFigure(matrix, row, col, row, col + 1, row, col + 2, row + 1, col + 1);
                }
            }

            Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}", i, l, j, o, z, s, t);
        }

        private static int GetFigure(char[,] matrix, int r1, int c1, int r2, int c2, int r3, int c3, int r4, int c4)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (IsWithinRange(c1, cols) && IsWithinRange(r1, rows) &&
                IsWithinRange(c2, cols) && IsWithinRange(r2, rows) &&
                IsWithinRange(c3, cols) && IsWithinRange(r3, rows) &&
                IsWithinRange(c4, cols) && IsWithinRange(r4, rows))
            {
                if (matrix[r1, c1] == 'o' && matrix[r2, c2] == 'o' &&
                    matrix[r3, c3] == 'o' && matrix[r4, c4] == 'o')
                {
                    return 1;
                }
            }

            return 0;
        }

        private static bool IsWithinRange(int index, int border)
        {
            return index >= 0 && index < border;
        }
    }
}



