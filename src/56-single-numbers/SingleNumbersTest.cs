using System.Linq;
using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class SingleNumbersTest {
        [Test]
        public void Test() {
            var arr = new[] { 4, 1, 4, 6 };
            var res1 = new[] { 1, 6 };
            var res2 = new[] { 6, 1 };
            var got = SingleNumbers.Find(arr);
            var t = got.SequenceEqual(res1) || got.SequenceEqual(res2);
            Assert.IsTrue(t);
        }

        [Test]
        public void Test2() {
            var arr = new[] { 1, 2, 10, 4, 1, 4, 3, 3 };
            var res1 = new[] { 2, 10 };
            var res2 = new[] { 10, 2 };
            var got = SingleNumbers.Find(arr);
            var t = got.SequenceEqual(res1) || got.SequenceEqual(res2);
            Assert.IsTrue(t);
        }

        [Test]
        public void Test3() {
            var arr = new[] { 3, 4, 3, 3 };
            var got = SingleNumbers.Single(arr);
            Assert.AreEqual(4, got);
        }
    }
}
