using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class KthLargestTest {
        [Test]
        public void Test() {
            var node2 = new TreeNode { Val = 2 };
            var node1 = new TreeNode { Val = 1, Right = node2 };
            var node4 = new TreeNode { Val = 4 };
            var root = new TreeNode { Val = 3, Left = node1, Right = node4 };

            var obj = new KthLargest();
            var got = obj.Get(root, 1);
            Assert.AreEqual(4, got);
        }
    }
}
