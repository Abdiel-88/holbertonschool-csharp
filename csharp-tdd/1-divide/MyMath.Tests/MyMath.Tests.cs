using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] expected = { { 1, 2 }, { 3, 4 } };
            int[,] result = Matrix.Divide(matrix, 2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_DivideByZero_ReturnsNull()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 0);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);

            Assert.IsNull(result);
        }
    }
}
