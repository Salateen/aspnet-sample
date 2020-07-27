using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace aspnet_sample.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TrueShouldBeTrue()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void FalseShouldBeFalse()
        {
            Assert.AreEqual(false, true);
        }
    }
}
