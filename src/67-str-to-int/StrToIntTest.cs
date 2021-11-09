namespace CodingInterview;

using NUnit.Framework;

[TestFixture]
public class StrToIntTest {
    [Test]
    public void Test() {
        var s1 = new StrToInt();
        var n1 = s1.Get("   -42");
        Assert.AreEqual(-42, n1);

        var s2 = new StrToInt();
        var n2 = s2.Get("4193 with words");
        Assert.AreEqual(4193, n2);

        var s3 = new StrToInt();
        var n3 = s3.Get("words and 987");
        Assert.AreEqual(0, n3);
    }
}
