using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class FirstUniqCharTest {
        [Test]
        public void Test() {
            var s = "abaccdeff";
            var c = FirstUniqChar.Get(s);
            Assert.AreEqual('b', c);

            var s2 = "";
            var c2 = FirstUniqChar.Get(s2);
            Assert.AreEqual(' ', c2);
        }
    }
}
