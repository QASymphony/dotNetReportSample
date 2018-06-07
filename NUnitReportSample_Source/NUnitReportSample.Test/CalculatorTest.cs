using NUnit.Framework;
using NUnitReportSample.Library;

namespace NUnitReportSample.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            Calculator cal = new Calculator();
            int expectedResult = cal.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMultipleTwoNumbers()
        {
            Calculator cal = new Calculator();
            int expectedResult = cal.Mul(5, 10);
            Assert.That(expectedResult, Is.EqualTo(20));
        }
    }
}
