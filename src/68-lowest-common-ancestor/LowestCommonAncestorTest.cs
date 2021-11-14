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

    [Test]
    public void TestGetDFS() {
        var root = BuildTree.Build(new[] { 3, 5, 6, 2, 7, 4, 1, 0, 8 }, new[] { 6, 5, 7, 2, 4, 3, 0, 1, 8 });
        var node1 = LowestCommonAncestor.GetDFS(root, new TreeNode { Val = 5 }, new TreeNode { Val = 1 });
        Assert.AreEqual(3, node1?.Val);

        var node2 = LowestCommonAncestor.GetDFS(root, new TreeNode { Val = 5 }, new TreeNode { Val = 4 });
        Assert.AreEqual(5, node2?.Val);
    }
}
