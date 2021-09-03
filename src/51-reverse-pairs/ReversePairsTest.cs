using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class ReversePairsTest {
        [Test]
        public void Test() {
            var a = new[] { 7, 5, 6, 4 };
            var r = ReversePairs.Reverse(a);
            Assert.AreEqual(5, r);
        }
    }
}
