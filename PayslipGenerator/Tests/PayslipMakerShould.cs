using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    [TestFixture]
    public class PayslipMakerShould
    {
        [Test]
        public void ReturnOutputPayslipForDavid()
        {
            var payslipMaker = new PayslipMaker(new Calculator(new DefaultTaxTable()));
            var employee = new EmployeeDetails("David", "Rudd", 60050, 0.09, "01 March - 31 March");

            var expectedPayslip = new Payslip("David Rudd", "01 March - 31 March", 5004, 922, 4082, 450);

            Assert.AreEqual(expectedPayslip, payslipMaker.Compute(employee));
        }

        [Test]
        public void ReturnOutputPayslipForRyan()
        {
            var payslipMaker = new PayslipMaker(new Calculator(new DefaultTaxTable()));
            var employee = new EmployeeDetails("Ryan", "Chen", 120000, 0.1, "01 March - 31 March");

            var expectedPayslip = new Payslip("Ryan Chen", "01 March - 31 March", 10000, 2696, 7304, 1000);

            Assert.AreEqual(expectedPayslip, payslipMaker.Compute(employee));
        }

    }
}
