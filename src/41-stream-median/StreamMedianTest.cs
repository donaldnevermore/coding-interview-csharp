using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class StreamMedianTest {
        [Test]
        public void Test() {
            var sm = new StreamMedian();
            sm.Insert(2);
            sm.Insert(4);
            sm.Insert(6);

            var r1 = sm.GetMedian();
            Assert.AreEqual(4, r1);

            sm.Insert(8);
            var r2 = sm.GetMedian();
            Assert.AreEqual(5, r2);
        }
    }
}
