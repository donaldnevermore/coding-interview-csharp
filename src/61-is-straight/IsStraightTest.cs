using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class IsStraightTest {
        [Test]
        public void TestFind() {
            var a = IsStraight.Find(new[] { 1, 2, 3, 4, 5 });
            Assert.IsTrue(a);

            var b = IsStraight.Find(new[] { 0, 0, 1, 2, 5 });
            Assert.IsTrue(b);
        }
    }
}
