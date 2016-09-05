using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleNetCoreUnitTests
{
    [TestClass]
    public class TestClasss
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethodFailing()
        {
            Assert.IsTrue(false);
        }
    }
}