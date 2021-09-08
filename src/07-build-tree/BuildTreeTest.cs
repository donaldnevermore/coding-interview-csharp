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
    }
}
