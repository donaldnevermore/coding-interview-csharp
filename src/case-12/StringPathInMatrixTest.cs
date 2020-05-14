using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class StringPathInMatrixTest {
        [Test]
        public void TestHasPath() {
            char[] matrix = {'a', 'b', 't', 'g', 'c', 'f', 'c', 's', 'j', 'd', 'e', 'h'};
            const string bfce = "bfce";
            const string abfb = "abfb";
            var result1 = StringPathInMatrix.HasPath(matrix, 3, 4, bfce);
            Assert.AreEqual(true, result1);
            var result2 = StringPathInMatrix.HasPath(matrix, 3, 4, abfb);
            Assert.AreEqual(false, result2);
        }
    }
}
