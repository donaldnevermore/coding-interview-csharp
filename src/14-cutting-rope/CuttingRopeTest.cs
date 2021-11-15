namespace CodingInterview;

using NUnit.Framework;

[TestFixture]
public class CuttingRopeTest {
    [Test]
    public void TestMaxProductDP() {
        Assert.AreEqual(1, CuttingRope.MaxProductDP(2));
        Assert.AreEqual(4, CuttingRope.MaxProductDP(4));
        Assert.AreEqual(18, CuttingRope.MaxProductDP(8));
        Assert.AreEqual(27, CuttingRope.MaxProductDP(9));
        Assert.AreEqual(36, CuttingRope.MaxProductDP(10));
    }

    [Test]
    public void TestMaxProductGreedy() {
        Assert.AreEqual(1, CuttingRope.MaxProductGreedy(2));
        Assert.AreEqual(4, CuttingRope.MaxProductGreedy(4));
        Assert.AreEqual(18, CuttingRope.MaxProductGreedy(8));
        Assert.AreEqual(27, CuttingRope.MaxProductGreedy(9));
        Assert.AreEqual(36, CuttingRope.MaxProductGreedy(10));
    }

    [Test]
    public void TestMaxProductGreedyMod() {
        Assert.AreEqual(1, CuttingRope.MaxProductGreedyMod(2));
        Assert.AreEqual(4, CuttingRope.MaxProductGreedyMod(4));
        Assert.AreEqual(18, CuttingRope.MaxProductGreedyMod(8));
        Assert.AreEqual(27, CuttingRope.MaxProductGreedyMod(9));
        Assert.AreEqual(36, CuttingRope.MaxProductGreedyMod(10));
    }
}
