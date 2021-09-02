using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class FindNumberIn2DArrayTest {
        [Test]
        public void Test() {
            var m = new[] {
                new[] { 1, 4, 7, 11, 15 },
                new[] { 2, 5, 8, 12, 19 },
                new[] { 3, 6, 9, 16, 22 },
                new[] { 10, 13, 14, 17, 24 },
                new[] { 18, 21, 23, 26, 30 }
            };
            var b = FindNumberIn2DArray.Find(m, 5);
            var b2 = FindNumberIn2DArray.Find(m, 20);
            Assert.IsTrue(b);
            Assert.IsFalse(b2);
        }
    }
}
