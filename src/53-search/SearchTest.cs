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

        [Test]
        public void TestMissingNumber() {
            var nums = new[] { 0 };
            var got = Search.MissingNumber(nums);
            Assert.AreEqual(1, got);

            var nums2 = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 };
            var got2 = Search.MissingNumber(nums2);
            Assert.AreEqual(8, got2);
        }

        [Test]
        public void TestNumberEqualsIndex() {
            var nums = new[] { 0 };
            var got = Search.NumberEqualsIndex(nums);
            Assert.AreEqual(0, got);

            var nums2 = new[] { -3, -1, 1, 3, 5 };
            var got2 = Search.NumberEqualsIndex(nums2);
            Assert.AreEqual(3, got2);

            var nums3 = new[] { 1 };
            var got3 = Search.NumberEqualsIndex(nums3);
            Assert.AreEqual(-1, got3);
        }
    }
}
