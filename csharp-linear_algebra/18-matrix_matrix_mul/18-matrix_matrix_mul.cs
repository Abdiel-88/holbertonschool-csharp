using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Get the dimensions of both matrices
        int rowsMatrix1 = matrix1.GetLength(0);
        int colsMatrix1 = matrix1.GetLength(1);
        int rowsMatrix2 = matrix2.GetLength(0);
        int colsMatrix2 = matrix2.GetLength(1);

        // Check if the matrices can be multiplied (cols of matrix1 == rows of matrix2)
        if (colsMatrix1 != rowsMatrix2)
        {
            return new double[,] { { -1 } };
        }

        // Initialize the result matrix
        double[,] result = new double[rowsMatrix1, colsMatrix2];

        // Perform matrix multiplication
        for (int i = 0; i < rowsMatrix1; i++)
        {
            for (int j = 0; j < colsMatrix2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsMatrix1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
