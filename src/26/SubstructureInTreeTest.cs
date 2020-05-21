using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class SubstructureInTreeTest {
        [Test]
        public void TestInTree() {
            var root1 = new BinaryTreeNode {
                Value = 8,
                Left = new BinaryTreeNode {
                    Value = 8,
                    Left = new BinaryTreeNode {Value = 9},
                    Right = new BinaryTreeNode {Value = 2}
                },
                Right = new BinaryTreeNode {Value = 7}
            };
            var root2 = new BinaryTreeNode {
                Value = 8,
                Left = new BinaryTreeNode {Value = 9},
                Right = new BinaryTreeNode {Value = 2}
            };
            Assert.AreEqual(true, SubstructureInTree.HasSubTree(root1, root2));
        }

        [Test]
        public void TestNotInTree() {
            var root1 = new BinaryTreeNode {Value = 1};
            var root2 = new BinaryTreeNode {Value = 2};
            Assert.AreEqual(false, SubstructureInTree.HasSubTree(root1, root2));
            Assert.AreEqual(false, SubstructureInTree.HasSubTree(null, null));
            Assert.AreEqual(false, SubstructureInTree.HasSubTree(null, root2));
            Assert.AreEqual(false, SubstructureInTree.HasSubTree(root1, null));
        }
    }
}
