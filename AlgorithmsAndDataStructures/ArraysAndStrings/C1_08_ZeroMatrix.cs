using ArraysAndStrings.HelperClasses;
using System;

namespace ArraysAndStrings
{
    public class C1_08_ZeroMatrix
    {
        public static void SetToZero()
        {
            Matrix helperMatrix = new Matrix();

            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            matrix = helperMatrix.InitializeMatrix(matrix, rows, columns);

            //matrix[rows - 1, columns - 1] = 0;
            matrix[2, 2] = 0;

            helperMatrix.ShowMatrix(matrix, rows, columns);

            bool[] tempRows = new bool[matrix.GetLength(0)];
            bool[] tempColumns = new bool[matrix.GetLength(1)];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        tempRows[i] = true;
                        tempColumns[j] = true;
                    }
                }
            }

            // Set all the Column to Zero
            for (int i = 0; i < rows; i++)
            {
                if(tempRows[i] == true)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            // Set all the Rows to Zero
            for (int j = 0; j < columns; j++)
            {
                if (tempColumns[j] == true)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            Console.WriteLine();
            helperMatrix.ShowMatrix(matrix, rows, columns);
        }
    }
}
