using System;

/// <sumary>
/// method that calculates dot product of either two 2D
/// or two 3D vectors.
/// </sumary>
class VectorMath
{
    /// <sumary>
    /// The vectors can be either both 2D or both 3D
    /// If any vector is not a 2D or 3D vector.
    /// or both vectors are not the same size
    /// </sumary>
    /// <return>
    /// return -1
    /// </return>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dot_product = 0;
        int i;

        if (vector1.Length != vector2.Length || vector1.Length < 2
        || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
        {
            return (-1);
        }

        for (i = 0; i < vector1.Length; i++)
        {
            dot_product += Math.Round(vector1[i] * vector2[i], 2);
        }
        return dot_product;
    }
}