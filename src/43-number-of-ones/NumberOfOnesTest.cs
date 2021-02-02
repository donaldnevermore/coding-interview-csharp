using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class NumberOfOnesTest {
        [Test]
        public void Test() {
            var i = 12;
            var result = NumberOfOnes.NumberOfOnesBetween(i);
            Assert.AreEqual(5, result);
        }
    }
}
