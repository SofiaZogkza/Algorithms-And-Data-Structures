using ArraysAndStrings.HelperClasses;
using System;

namespace ArraysAndStrings
{
    public class RotateMatrix
    {
        Matrix helperMatrix = new Matrix();

        public static void MatrixRotation()
        {
            int rows = 4;
            int columns = 4;
            int[,] matrix = new int[rows,columns];
            
            matrix = helperMatrix.InitializeMatrix(matrix, rows, columns);
            /* 1 2 3 4
             * 5 6 7 8
             * 9 10 11 12
             * 13 14 15 16
             * 
             * 4 8 12 16
             * 3 7 11 15
             * 2 6 10 14
             * 1 5 9  13
             */


            ShowMatrix(matrix, rows, columns);

            Console.WriteLine();

            Rotate(matrix, rows);

            ShowMatrix(matrix, rows, columns);
        }

        public static bool Rotate(int[,] matrix, int N)
        {
            if (matrix.Length == 0 || 
                matrix.Length == matrix[0,0])
            {
                return false;
            }
                
            
            for (int layer = 0; layer < N / 2; layer++)
            {
                for (int y = layer; y < N - layer - 1; y++)
                {
                    // store current cell in temp variable 
                    int temp = matrix[layer, y];

                    // move values from right to top 
                    matrix[layer, y] = matrix[y, N - 1 - layer];

                    // move values from bottom to right 
                    matrix[y, N - 1 - layer] = matrix[N - 1 - layer, N - 1 - y];

                    // move values from left to bottom 
                    matrix[N - 1 - layer, N - 1 - y] = matrix[N - 1 - y, layer];

                    // assign temp to left 
                    matrix[N - 1 - y, layer] = temp;
                }
            }
            return true;
        }

        

        public static void ShowMatrix(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
