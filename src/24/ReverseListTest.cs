using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class ReverseListTest {
        [Test]
        public void TestReverse() {
            Assert.AreEqual(null, ReverseList.Reverse(null));

            var node1 = new ListNode {Value = 1};
            Assert.AreEqual(node1, ReverseList.Reverse(node1));

            var node2 = new ListNode {Value = 2};
            node1.Next = node2;
            Assert.AreEqual(node2, ReverseList.Reverse(node1));
        }
    }
}
