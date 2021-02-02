using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class KLeastNumbersTest {
        [Test]
        public void Test() {
            var arr = new[] { 4, 5, 1, 6, 2, 7, 3, 8 };
            var expected = new[] { 1, 2, 3, 4 };
            var actual = KLeastNumbers.Get(arr, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
