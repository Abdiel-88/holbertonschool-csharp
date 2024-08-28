namespace MyMath
{
    /// <summary>
    /// Provides methods for matrix operations.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of the matrix by the given number.
        /// </summary>
        /// <param name="matrix">The matrix to be divided.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>A new matrix containing divided elements, or null if num is zero or matrix is null.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null) return null;
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }

            return result;
        }
    }
}
