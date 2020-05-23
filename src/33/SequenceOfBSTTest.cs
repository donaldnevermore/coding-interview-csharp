using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class SequenceOfBSTTest {
        [Test]
        public void TestIsSequenceOfBST() {
            Assert.AreEqual(true, SequenceOfBST.IsSequenceOfBST(new int[] {
                5, 7, 6, 9, 11, 10, 8
            }));
            Assert.AreEqual(false, SequenceOfBST.IsSequenceOfBST(new int[] {
                7, 4, 6, 5
            }));
        }
    }
}
