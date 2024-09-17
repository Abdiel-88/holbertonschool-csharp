using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Ensure the matrix is 2x2 (square matrix)
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Calculate the rotation matrix for the given angle
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double[,] rotationMatrix = new double[,]
        {
            { cosTheta, -sinTheta },
            { sinTheta, cosTheta }
        };

        double[,] result = new double[2, 2];

        // Perform matrix multiplication: result = rotationMatrix * matrix
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += rotationMatrix[i, k] * matrix[k, j];
                }
            }
        }

        return result;
    }
}
