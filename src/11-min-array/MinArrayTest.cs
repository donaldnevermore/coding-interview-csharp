using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MinArrayTest {
        [Test]
        public void TestMin() {
            var arr = new[] { 3, 4, 5, 1, 2 };
            var got = MinArray.MinNumber(arr);
            Assert.AreEqual(1, got);

            var arr2 = new[] { 2, 2, 2, 0, 1 };
            var got2 = MinArray.MinNumber(arr2);
            Assert.AreEqual(0, got2);
        }
    }
}
