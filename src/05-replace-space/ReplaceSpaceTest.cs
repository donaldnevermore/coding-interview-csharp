using NUnit.Framework;

namespace CodingInterview.Test {
    [TestFixture]
    public class ReplaceSpaceTest {
        [Test]
        public void TestReplace() {
            var str = "We are happy.";
            var newStr = "We%20are%20happy.";
            var r = ReplaceSpace.Replace(str);
            Assert.AreEqual(newStr, r);
        }
    }
}
