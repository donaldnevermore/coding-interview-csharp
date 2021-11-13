namespace CodingInterview;

using NUnit.Framework;

[TestFixture]
public class LowestCommonAncestorTest {
    [Test]
    public void TestGetBST() {
        var root = BuildTree.Build(new[] { 6, 2, 0, 4, 3, 5, 8, 7, 9 }, new[] { 0, 2, 3, 4, 5, 6, 7, 8, 9 });
        var node1 = LowestCommonAncestor.GetBST(root, new TreeNode { Val = 2 }, new TreeNode { Val = 8 });
        Assert.AreEqual(6, node1?.Val);

        var node2 = LowestCommonAncestor.GetBST(root, new TreeNode { Val = 2 }, new TreeNode { Val = 4 });
        Assert.AreEqual(2, node2?.Val);

    }
}
