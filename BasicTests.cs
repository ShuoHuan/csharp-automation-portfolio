using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void Test_Addition()
        {
            int result = 2 + 2;
            Assert.AreEqual(4, result);
        }
    }
}
