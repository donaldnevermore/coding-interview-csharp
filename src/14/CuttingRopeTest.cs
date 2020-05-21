using NUnit.Framework;

namespace CodingInterview.Test {
    [TestFixture]
    public class CuttingRopeTest {
        [Test]
        public void TestMaxProductDynamic() {
            Assert.AreEqual(1, CuttingRope.MaxProductDynamic(2));
            Assert.AreEqual(4, CuttingRope.MaxProductDynamic(4));
            Assert.AreEqual(18, CuttingRope.MaxProductDynamic(8));
            Assert.AreEqual(27, CuttingRope.MaxProductDynamic(9));
            Assert.AreEqual(36, CuttingRope.MaxProductDynamic(10));
        }

        [Test]
        public void TestMaxProductGreedy() {
            Assert.AreEqual(1, CuttingRope.MaxProductGreedy(2));
            Assert.AreEqual(4, CuttingRope.MaxProductGreedy(4));
            Assert.AreEqual(18, CuttingRope.MaxProductGreedy(8));
            Assert.AreEqual(27, CuttingRope.MaxProductGreedy(9));
            Assert.AreEqual(36, CuttingRope.MaxProductGreedy(10));
        }
    }
}
