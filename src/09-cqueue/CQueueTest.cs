using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class CQueueTest {
        [Test]
        public void TestCQueue() {
            var queue = new CQueue();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');
            var first = queue.DeleteHead();
            Assert.AreEqual('a', first);
            var second = queue.DeleteHead();
            Assert.AreEqual('b', second);
            queue.AppendTail('d');
            var third = queue.DeleteHead();
            Assert.AreEqual('c', third);
        }
    }
}
