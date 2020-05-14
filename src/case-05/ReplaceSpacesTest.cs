using NUnit.Framework;

namespace CodingInterview.Test {
    [TestFixture]
    public class ReplaceSpacesTest {
        [Test]
        public void TestReplaceBlanks() {
            char[] str = {'w', ' ', 'e', '\0', '\0'};
            char[] strNew = {'w', '%', '2', '0', 'e'};
            var len = 5;
            ReplaceSpaces.ReplaceBlanks(str, len);
            Assert.AreEqual(str, strNew);
        }
    }
}