namespace CodingInterview;

using NUnit.Framework;

[TestFixture]
public class RegularExpressionsMatchingTest {
    [Test]
    public void TestMatch() {
        Assert.AreEqual(true, IsMatch.Match("aaa", "a.a"));
        Assert.AreEqual(true, IsMatch.Match("aaa", "ab*ac*a"));
        Assert.AreEqual(false, IsMatch.Match("aaa", "aa.a"));
        Assert.AreEqual(false, IsMatch.Match("aaa", "ab*a"));
    }
}
