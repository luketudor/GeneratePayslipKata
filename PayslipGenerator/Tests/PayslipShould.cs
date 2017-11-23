using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    [TestFixture]
    class PayslipShould
    {
        [Test]
        public void ReturnsAllPayslipValues()
        {
            var name = "Foo Bar";
            var payPeriod = "01 March - 31 March";
            var grossIncome = 5000;
            var incomeTax = 450;
            var netIncome = 3000;
            var super = 100;
            var payslip = new Payslip(name, payPeriod, grossIncome, incomeTax, netIncome, super);

            var expectedName = name;
            var expectedPeriod = payPeriod;
            var expectedGIncome = grossIncome;
            var expectedTax = incomeTax;
            var expectedNIncome = netIncome;
            var expectedSuper = super;

            Assert.AreEqual(expectedName, payslip.Name);
            Assert.AreEqual(expectedPeriod, payslip.PayPeriod);
            Assert.AreEqual(expectedGIncome, payslip.GrossIncome);
            Assert.AreEqual(expectedTax, payslip.IncomeTax);
            Assert.AreEqual(expectedNIncome, payslip.NetIncome);
            Assert.AreEqual(expectedSuper, payslip.Super);
        }
    }
}
