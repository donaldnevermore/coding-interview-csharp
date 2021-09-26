using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MovingCountTest {
        [Test]
        public void TestMoving() {
            var got = MovingCount.Moving(2, 3, 1);
            Assert.AreEqual(3, got);

            var got2 = MovingCount.Moving(3, 1, 0);
            Assert.AreEqual(1, got2);
        }
    }
}
