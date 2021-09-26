﻿using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class MaxSlidingWindowTest {
        [Test]
        public void Test() {
            var nums = new[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            var want = new[] { 3, 3, 5, 5, 6, 7 };
            var got = MaxSlidingWindow.Max(nums, 3);
            Assert.AreEqual(want, got);
        }
    }
}
