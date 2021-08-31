using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class LengthOfLongestSubstringTest {
        [Test]
        public void TestFind() {
            var s = "arabcacfr";
            var r = LengthOfLongestSubstring.Find(s);
            Assert.AreEqual(4, r);

            var s2 = "abcabcbb";
            var r2 = LengthOfLongestSubstring.Find(s2);
            Assert.AreEqual(3, r2);

            var s3 = "bbbbb";
            var r3 = LengthOfLongestSubstring.Find(s3);
            Assert.AreEqual(1, r3);

            var s4 = "pwwkew";
            var r4 = LengthOfLongestSubstring.Find(s4);
            Assert.AreEqual(3, r4);
        }
    }
}
