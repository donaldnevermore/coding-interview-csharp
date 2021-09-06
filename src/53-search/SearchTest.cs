using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class SearchTest {
        [Test]
        public void Test() {
            var nums = new[] { 5, 7, 7, 8, 8, 10 };
            var got = Search.Get(nums, 8);
            Assert.AreEqual(2, got);

            var nums2 = new[] { 5, 7, 7, 8, 8, 10 };
            var got2 = Search.Get(nums2, 6);
            Assert.AreEqual(0, got2);
        }
    }
}
