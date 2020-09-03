using NUnit.Framework;

namespace CodingInterview
{
    [TestFixture]
    public class GreatestSumOfSubArraysTest
    {
        [Test]
        public void TestFind()
        {
            var arr = new[] {1, -2, 3, 10, -4, 7, 2, -5};
            var result = GreatestSumOfSubArrays.Find(arr);
            Assert.AreEqual(18, result);
        }
    }
}
