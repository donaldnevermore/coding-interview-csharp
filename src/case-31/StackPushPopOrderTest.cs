using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class StackPushPopOrderTest {
        [Test]
        public void TestIsPopOrder() {
            int[] push = {1, 2, 3, 4, 5};
            int[] rightPop = {4, 5, 3, 2, 1};
            Assert.AreEqual(true, StackPushPopOrder.IsPopOrder(push, rightPop));

            int[] wrongPop = {4, 3, 5, 1, 2};
            Assert.AreEqual(false, StackPushPopOrder.IsPopOrder(push, wrongPop));
        }
    }
}
