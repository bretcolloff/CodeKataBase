using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Example test method demonstrating common assertions.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
            Assert.IsFalse(false);
            Assert.AreEqual(1, 1);
            Assert.AreNotEqual(0, 1);
        }
    }
}
