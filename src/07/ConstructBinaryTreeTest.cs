using System;
using NUnit.Framework;

namespace CodingInterview.Test {
    [TestFixture]
    public class ConstructBinaryTreeTest {
        [Test]
        public void TestConstruct() {
            int[] preorder = { 1, 2, 4, 7, 3, 5, 6, 8 };
            int[] inorder = { 4, 7, 2, 1, 5, 3, 8, 6 };
            var result = ConstructBinaryTree.Construct(preorder, inorder);
            Console.WriteLine(result);
        }
    }
}
