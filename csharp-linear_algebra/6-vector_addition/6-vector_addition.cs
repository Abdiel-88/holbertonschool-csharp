using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if both vectors are 2D or 3D and of the same size
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            double[] result = new double[vector1.Length];

            // Perform element-wise addition
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }

            return result;
        }

        // Return a vector containing -1 if they are not 2D/3D or not the same size
        return new double[] { -1 };
    }
}
