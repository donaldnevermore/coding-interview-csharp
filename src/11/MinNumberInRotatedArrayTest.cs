using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MinNumberInRotatedArrayTest {
        [Test]
        public void TestMin() {
            int[] arr1 = { 3, 4, 5, 1, 2 };
            Assert.AreEqual(1, MinNumberInRotatedArray.Min(arr1));
            int[] arr2 = { 1, 0, 1, 1, 1 };
            Assert.AreEqual(0, MinNumberInRotatedArray.Min(arr2));
        }
    }
}
