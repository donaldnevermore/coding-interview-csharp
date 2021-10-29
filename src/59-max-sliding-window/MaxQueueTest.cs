using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MaxQueueTest {
        [Test]
        public void TestMaxQueue() {
            var mq = new MaxQueue();
            var got = mq.MaxValue();
            Assert.AreEqual(-1, got);

            mq.PushBack(3);
            var got3 = mq.PopFront();
            Assert.AreEqual(3, got3);

            mq.PushBack(4);
            mq.PushBack(1);
            mq.PushBack(3);
            mq.PushBack(5);

            var got5 = mq.MaxValue();
            Assert.AreEqual(5, got5);
        }
    }
}
