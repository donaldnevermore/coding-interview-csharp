using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class NthUglyNumberTest {
        [Test]
        public void TestNthUglyNumber() {
            var r = NthUglyNumber.Get(10);
            Assert.AreEqual(12, r);
        }
    }
}
