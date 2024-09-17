using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is either 2D or 3D
        if (vector.Length == 2)
        {
            // Calculate the magnitude for a 2D vector
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
        }
        else if (vector.Length == 3)
        {
            // Calculate the magnitude for a 3D vector
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
        }
        else
        {
            // Return -1 if the vector is not 2D or 3D
            return -1;
        }
    }
}
