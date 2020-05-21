using System;
using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MinInStackTest {
        [Test]
        public void Test() {
            var stack = new MinInStack();
            stack.Push(5);
            stack.Push(6);
            Assert.AreEqual(5, stack.Min());

            stack.Push(4);
            stack.Push(7);
            Assert.AreEqual(4, stack.Min());

            stack.Pop();
            stack.Pop();
            Assert.AreEqual(5, stack.Min());
        }

        [Test]
        public void TestException() {
            var stack = new MinInStack();
            Assert.Throws<Exception>(() => { stack.Min(); });
        }
    }
}
