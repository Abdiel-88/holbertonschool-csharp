using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the Operations class.
    /// </summary>
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 16, 32 } };
            int divisor = 4;
            int[,] expected = { { 1, 2 }, { 4, 8 } };

            int[,] result = Matrix.Divide(matrix, divisor);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_DivisorZero_ReturnsNull()
        {
            int[,] matrix = { { 4, 8 }, { 16, 32 } };

            int[,] result = Matrix.Divide(matrix, 0);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] matrix = null;

            int[,] result = Matrix.Divide(matrix, 2);

            Assert.IsNull(result);
        }
    }
}
