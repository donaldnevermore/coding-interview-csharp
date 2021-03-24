using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class EntryNodeInListLoopTest {
        [Test]
        public void TestEntryOfLoop() {
            var node1 = new ListNode { Value = 1 };
            var node2 = new ListNode { Value = 2 };
            node1.Next = node2;
            var node3 = new ListNode { Value = 3 };
            node2.Next = node3;
            node3.Next = node2;

            Assert.AreEqual(node2, EntryNodeInListLoop.EntryNodeOfLoop(node1));
        }

        [Test]
        public void TestNoEntryOfLoop() {
            var node1 = new ListNode { Value = 1 };
            Assert.AreEqual(null, EntryNodeInListLoop.EntryNodeOfLoop(node1));

            var node2 = new ListNode { Value = 2 };
            node1.Next = node2;
            Assert.AreEqual(null, EntryNodeInListLoop.EntryNodeOfLoop(node1));
        }
    }
}
