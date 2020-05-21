using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class RegularExpressionsMatchingTest {
        [Test]
        public void TestMatch() {
            Assert.AreEqual(true, RegularExpressionsMatching.Match("aaa", "a.a"));
            Assert.AreEqual(true, RegularExpressionsMatching.Match("aaa", "ab*ac*a"));
            Assert.AreEqual(false, RegularExpressionsMatching.Match("aaa", "aa.a"));
            Assert.AreEqual(false, RegularExpressionsMatching.Match("aaa", "ab*a"));
        }
    }
}
