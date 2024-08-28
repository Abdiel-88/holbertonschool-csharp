using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            int result = Operations.Add(5, -2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(-4, -6);
            Assert.AreEqual(-10, result);
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsNumber()
        {
            int result = Operations.Add(0, 7);
            Assert.AreEqual(7, result);
        }
    }
}
