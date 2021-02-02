using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MoreThanHalfNumberTest {
        [Test]
        public void TestMoreThanHalfNumber() {
            var result = MoreThanHalfNumber.Get(new[] { 1, 2, 3, 2, 2, 2, 5, 4, 2 });
            Assert.AreEqual(2, result);
        }
    }
}
