namespace CodingInterview;

using NUnit.Framework;

[TestFixture]
public class FindRepeatNumberTest {
  [Test]
  public static void TestGet() {
    var a = new[] { 2, 3, 1, 0, 2, 5, 3 };
    var r = FindRepeatNumber.Get(a);
    Assert.IsTrue(r == 2 || r == 3);

    var a2 = new[] { 2, 3, 5, 4, 3, 2, 6, 7 };
    var r2 = FindRepeatNumber.GetWithArrayIntact(a2);
    Assert.IsTrue(r2 == 2 || r2 == 3);
  }
}
