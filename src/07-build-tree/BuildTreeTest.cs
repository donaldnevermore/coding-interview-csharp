using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class BuildTreeTest {
        [Test]
        public void TestBuild() {
            var preorder = new[] { 3, 9, 20, 15, 7 };
            var inorder = new[] { 9, 3, 15, 20, 7 };
            var tree = BuildTree.Build(preorder, inorder);
            var got = BuildTree.LevelOrder(tree);
            var want = new int?[] { 3, 9, 20, null, null, 15, 7 };
            Assert.AreEqual(want, got);
        }

        [Test]
        public void TestGetHeight() {
            var preorder = new[] { 3, 9, 20, 15, 7 };
            var inorder = new[] { 9, 3, 15, 20, 7 };
            var tree = BuildTree.Build(preorder, inorder);
            var h = BuildTree.GetHeight(tree);
            Assert.AreEqual(3, h);

            var h2 = BuildTree.GetHeight(null);
            Assert.AreEqual(0, h2);

            var h3 = BuildTree.GetHeight(new TreeNode { Val = 1 });
            Assert.AreEqual(1, h3);
        }
    }
}
