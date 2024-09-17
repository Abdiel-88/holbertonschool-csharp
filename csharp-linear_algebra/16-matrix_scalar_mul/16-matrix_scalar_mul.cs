using System;


/// <sumary>
/// method that multiplies a matrix and a scalar
/// and returns the resulting matrix.
/// </sumary>
class MatrixMath
{
    /// <sumary>
    /// The matrix can be either 2D or 3d
    /// The matrix can be either 2D or 3D
    /// </sumary>
    /// <return>
    /// return a matrix containing -1
    /// </return>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double [,] mult_matrix = new double [matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) < 2|| matrix.GetLength(0) > 3
        || matrix.GetLength(1) < 2|| matrix.GetLength(1) > 3)
        {
            return new double[,] {{-1}};
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                mult_matrix[i, j] = Math.Round(matrix[i, j] * scalar, 2);
            }
        }
        return (mult_matrix);
    }
}