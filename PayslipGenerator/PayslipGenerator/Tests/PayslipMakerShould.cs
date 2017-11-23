using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    //[TestFixture]
    public class PayslipMakerShould
    {
        

        [Test]
        public void ReturnsFirstAndLastName() 
        {
            var firstName = "Foo";
            var lastName = "Bar";
            var annualSalary = 40000;
            var superRate = 0.05;
            var startDate = "01 March";
            var payslip = new PayslipMaker(firstName, lastName, annualSalary, superRate, startDate);

            var expectedName = "Foo Bar";

            Assert.AreEqual(expectedName, payslip.Name);
        }

        [Test]
        public void ReturnsDifferentFirstAndLastName()
        {
            var firstName = "John";
            var lastName = "Doe";
            var annualSalary = 120000;
            var superRate = 0.4;
            var startDate = "01 February";
            var payslip = new PayslipMaker(firstName, lastName, annualSalary, superRate, startDate);

            var expectedName = "John Doe";

            Assert.AreEqual(expectedName, payslip.Name);
        }

        [Test]
        public void ReturnsGrossIncome()
        {
            var firstName = "Foo";
            var lastName = "Bar";
            var annualSalary = 40000;
            var superRate = 0.05;
            var startDate = "01 March";
            var payslip = new PayslipMaker(firstName, lastName, annualSalary, superRate, startDate);
            var calculator = new Calculator();

            var expectedIncome = 3333;

            Assert.AreEqual(expectedIncome, payslip.GrossIncome(calculator));
        }

        [Test]
        public void ReturnsDifferentGrossIncome()
        {
            var firstName = "John";
            var lastName = "Doe";
            var annualSalary = 120000;
            var superRate = 0.4;
            var startDate = "01 February";
            var payslip = new PayslipMaker(firstName, lastName, annualSalary, superRate, startDate);
            var calculator = new Calculator();

            var expectedIncome = 10000;

            Assert.AreEqual(expectedIncome, payslip.GrossIncome(calculator));
        }
    }
}
