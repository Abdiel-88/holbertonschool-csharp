using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
            Assert.AreEqual(-1, Operations.Add(-2, 1));
            Assert.AreEqual(0, Operations.Add(0, 0));
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }
    }
}
