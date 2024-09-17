using System;

/// <sumary>
/// method that adds two matrices and returns the resulting matrix
/// </sumary>
class MatrixMath
{
    /// <sumary>
    /// The matrices can be either both 2D or both 3D
    /// If any matrix is not a 2D or 3D matrix,
    /// or both matrices are not the same size
    /// </sumary>
    /// <return>
    /// return a matrix containing -1
    /// </return>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double [,] sum_matrix = new double [matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(0) != matrix2.GetLength(0)
        || matrix1.GetLength(0) < 2|| matrix1.GetLength(0) > 3
        || matrix2.GetLength(0) < 2|| matrix2.GetLength(0) > 3
        || matrix1.GetLength(1) < 2|| matrix1.GetLength(1) > 3
        || matrix2.GetLength(1) < 2|| matrix2.GetLength(1) > 3)
        {
            return new double [,] {{-1}};
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                sum_matrix[i,j] = Math.Round(matrix1[i,j] + matrix2[i,j], 2);
            }
        }
        return (sum_matrix);
    }
}