using System;

/// <sumary>
/// method that multiplies two matrices,
/// and returns the resulting matrix.
/// </sumary>
class MatrixMath
{
    /// <sumary>
    /// The matrices will not necessarily
    /// be square or the same dimensions
    /// If the matrices cannot be multiplied,
    /// </sumary>
    /// <return>
    /// return a matrix containing -1
    /// </return>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] mult_matrix = new double[matrix2.GetLength(0), matrix2.GetLength(1)];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return new double[,] {{-1}};
        }

        for (int i = 0; i < mult_matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mult_matrix.GetLength(1); j++)
            {
                double temp = 0;
                for (int k = 0; k < mult_matrix.GetLength(0); k++)
                {
                    temp += matrix1[i,k] * matrix2[k,j];
                }
                mult_matrix[i,j] = Math.Round(temp, 2);
            }
        }
        return mult_matrix;
    }
}