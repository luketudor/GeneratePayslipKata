using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    [TestFixture]
    public class PayslipAdaptorShould
    {
        [Test]
        public void ReturnDavidsFormattedPayslip()
        {
            var payslip = new Payslip("David Rudd", "01 March - 31 March", 5004, 922, 4082, 450);
            var payslipAdapter = new PayslipParser(',');

            var expectedPayslip = "David Rudd,01 March - 31 March,5004,922,4082,450";

            Assert.AreEqual(expectedPayslip, payslipAdapter.Format(payslip));
        }

        [Test]
        public void ReturnRyansFormattedPayslip()
        {
            var payslip = new Payslip("Ryan Chen", "01 March - 31 March", 10000, 2696, 7304, 1000);
            var payslipAdapter = new PayslipParser(',');

            var expectedPayslip = "Ryan Chen,01 March - 31 March,10000,2696,7304,1000";

            Assert.AreEqual(expectedPayslip, payslipAdapter.Format(payslip));
        }

        [Test]
        public void ReturnDavidsParsedDetails()
        {
            var employee = "David,Rudd,60050,9%,01 March - 31 March";
            var payslipAdapter = new PayslipParser(',');

            var expectedEmployee = new EmployeeDetails("David", "Rudd", 60050, 0.09, "01 March - 31 March");

            Assert.AreEqual(expectedEmployee, payslipAdapter.ParseEmployee(employee));
        }

        [Test]
        public void ReturnRyansParsedDetails()
        {
            var employee = "Ryan,Chen,120000,10 %,01 March - 31 March";
            var payslipAdapter = new PayslipParser(',');

            var expectedEmployee = new EmployeeDetails("Ryan", "Chen", 120000, 0.1, "01 March - 31 March");

            Assert.AreEqual(expectedEmployee, payslipAdapter.ParseEmployee(employee));
        }
    }
}
