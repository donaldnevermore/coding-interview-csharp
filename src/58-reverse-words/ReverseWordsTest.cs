using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class ReverseWordsTest {
        [Test]
        public void Test() {
            var s = "I am a student.";
            var want = "student. a am I";
            var got = ReverseWords.Reverse(s);
            Assert.AreEqual(want, got);
        }

        [Test]
        public void Test2() {
            var s = "lrloseumgh";
            var want = "umghlrlose";
            var got = ReverseWords.ReverseLeftWords(s, 6);
            Assert.AreEqual(want, got);
        }
    }
}
