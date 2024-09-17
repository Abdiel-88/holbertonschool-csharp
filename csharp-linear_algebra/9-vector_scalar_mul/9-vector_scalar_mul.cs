using System;

/// <sumary>
/// method that multiplies a vector and a scalar
/// and returns the resulting vector.
/// </sumary>
class VectorMath
{
    /// <sumary>
    /// The vectors can be 2D or 3D
    /// If any vector is not a 2D or 3D vector.
    /// </sumary>
    /// <return>
    /// return a vector containing -1
    /// </return>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] new_vec = new double[vector.Length];
        int i;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return new double[] {-1};
        }
        for (i = 0; i < vector.Length; i++)
        {
            new_vec[i] = Math.Round(vector[i] * scalar, 2);
        }
        return new_vec;
    }
}