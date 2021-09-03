using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class SingletonTest {
        [Test]
        public void Test() {
            var a = Singleton.Instance;
            var b = Singleton.Instance;
            Assert.AreSame(a, b);

            var c = Singleton5.Instance;
            var d = Singleton5.Instance;
            Assert.AreSame(c, d);
        }
    }
}
