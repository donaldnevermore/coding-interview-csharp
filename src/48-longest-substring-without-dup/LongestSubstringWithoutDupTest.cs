using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class LongestSubstringWithoutDupTest {
        [Test]
        public void TestFind() {
            var s = "arabcacfr";
            var r = LongestSubstringWithoutDup.Find(s);
            Assert.AreEqual(4, r);
        }
    }
}
