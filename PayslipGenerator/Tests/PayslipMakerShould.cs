using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    [TestFixture]
    public class PayslipMakerShould
    {
        [Test]
        public void ReturnsOutputPayslipForDavid()
        {
            var details = "David,Rudd,60050,9%,01 March – 31 March";
            var payslipMaker = new PayslipMaker(',', new Calculator());

            var expectedPayslip = "David Rudd,01 March – 31 March,5004,922,4082,450";

            Assert.AreEqual(expectedPayslip, payslipMaker.FormattedPayslip(details));
        }

        [Test]
        public void ReturnsOutputPayslipForRyan()
        {
            var details = "Ryan,Chen,120000,10%,01 March – 31 March";
            var payslipMaker = new PayslipMaker(',', new Calculator());

            var expectedPayslip = "Ryan Chen,01 March – 31 March,10000,2696,7304,1000";

            Assert.AreEqual(expectedPayslip, payslipMaker.FormattedPayslip(details));
        }

    }
}
