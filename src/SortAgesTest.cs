using NUnit.Framework;

namespace CodingInterview.Test {
    [TestFixture]
    public class SortAgesTest {
        [Test]
        public void TestSort() {
            int[] arr = {2, 5, 3, 3};
            SortAges.Sort(arr);
            int[] arrSorted = {2, 3, 3, 5};
            Assert.AreEqual(arrSorted, arr);
        }
    }
}
