using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MaxDepthTest {
        [Test]
        public void TestGet() {
            var d = MaxDepth.Get(null);
            Assert.AreEqual(0, d);

            var d2 = MaxDepth.Get(new TreeNode { Val = 1 });
            Assert.AreEqual(1, d2);
        }
    }
}
