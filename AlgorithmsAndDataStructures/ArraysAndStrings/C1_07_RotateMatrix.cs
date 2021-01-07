using ArraysAndStrings.HelperClasses;
using System;

namespace ArraysAndStrings
{
    public class C1_07_RotateMatrix
    {        
        public static void MatrixRotation()
        {
            Matrix helperMatrix = new Matrix();
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

            helperMatrix.ShowMatrix(matrix, rows, columns);

            //Console.WriteLine();

            //Rotate(matrix, rows);

            //helperMatrix.ShowMatrix(matrix, rows, columns);

            Console.WriteLine();

            Rotate2(matrix, rows);

            helperMatrix.ShowMatrix(matrix, rows, columns);
        }

        public static bool Rotate(int[,] matrix, int N)
        {
            if (matrix.Length == 0 || 
                matrix.Length == matrix[0,0])
            {
                return false;
            }
                
            
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = i; j < N - i - 1; j++)
                {
                    // store current cell in temp variable 
                    int temp = matrix[i, j];

                    // move values from right to top 
                    matrix[i, j] = matrix[j, N - 1 - i];

                    // move values from bottom to right 
                    matrix[j, N - 1 - i] = matrix[N - 1 - i, N - 1 - j];

                    // move values from left to bottom 
                    matrix[N - 1 - i, N - 1 - j] = matrix[N - 1 - j, i];

                    // assign temp to left 
                    matrix[N - 1 - j, i] = temp;
                }
            }

            return true;
        }

        public static bool Rotate2(int[,] matrix, int N)
        {
            if (matrix.Length == 0 ||
                matrix.Length == matrix[0, 0])
            {
                return false;
            }
            // Flip Horizontaly
            // Swap 1st column with the last column and move on to the center.
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (N/2); j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, N - 1 - j];
                    matrix[i, N - 1 - j] = temp;
                }
            }

            return true;
        }
    }
}
