using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MaxProfitTest {
        [Test]
        public void Test() {
            var a = MaxProfit.Get(new[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(5, a);

            var b = MaxProfit.Get(new[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, b);
        }
    }
}
