namespace CodingInterview;

using NUnit.Framework;

[TestFixture]
public class SortAgesTest {
    [Test]
    public void TestSort() {
        var arr = new[] { 2, 5, 3, 3 };
        SortAges.Sort(arr);
        var arrSorted = new[] { 2, 3, 3, 5 };
        Assert.AreEqual(arrSorted, arr);
    }
}
