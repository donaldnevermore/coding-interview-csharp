using NUnit.Framework;

namespace CodingInterview {
    [TestFixture]
    public class NumericStringTest {
        [Test]
        public void TestIsNumeric() {
            Assert.AreEqual(true, new NumericString().IsNumeric("+100"));
            Assert.AreEqual(true, new NumericString().IsNumeric("5e2"));
            Assert.AreEqual(true, new NumericString().IsNumeric("-123"));
            Assert.AreEqual(true, new NumericString().IsNumeric("3.1416"));
            Assert.AreEqual(true, new NumericString().IsNumeric("-1E-6"));

            Assert.AreEqual(false, new NumericString().IsNumeric("12e"));
            Assert.AreEqual(false, new NumericString().IsNumeric("1a3.14"));
            Assert.AreEqual(false, new NumericString().IsNumeric("1.2.3"));
            Assert.AreEqual(false, new NumericString().IsNumeric("+-5"));
            Assert.AreEqual(false, new NumericString().IsNumeric("12e+5.4"));
        }
    }
}
