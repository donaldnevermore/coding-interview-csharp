using NUnit.Framework;

namespace CodingInterview.Test {
    [TestFixture]
    public class NextNodeInBinaryTreeTest {
        [Test]
        public void TestGetNext() {
            var node4 = new BinaryTreeNode { Val = 4, Left = null, Right = null, Parent = null };
            var node3 = new BinaryTreeNode { Val = 3, Left = null, Right = null, Parent = node4 };
            node4.Left = node3;
            var node2 = new BinaryTreeNode { Val = 2, Left = null, Right = null, Parent = node3 };
            node3.Right = node2;
            var node1 = new BinaryTreeNode { Val = 1, Left = null, Right = null, Parent = node2 };
            node2.Right = node1;

            var next = NextNodeInBinaryTree.GetNext(node1);
            Assert.AreEqual(node4, next);
        }
    }
}
