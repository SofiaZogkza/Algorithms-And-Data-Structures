using System;

namespace ArraysAndStrings.HelperClasses
{
    public class Matrix
    {
        public int[,] InitializeMatrix(int[,] matrix, int rows, int columns)
        {
            int count = 0;
            matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    count++;
                    matrix[i, j] = count;
                }
            }
            return matrix;
        }

        public void ShowMatrix(int[,] matrix, int rows, int columns)
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
