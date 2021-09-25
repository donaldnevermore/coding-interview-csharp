using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class ExistTest {
        [Test]
        public void TestHasPath() {
            var board = new[] {
                new[] { 'A', 'B', 'C', 'E' },
                new[] { 'S', 'F', 'C', 'S' },
                new[] { 'A', 'D', 'E', 'E' }
            };

            var got = Exist.HasPath(board, "ABCCED");
            Assert.AreEqual(true, got);
        }
    }
}
