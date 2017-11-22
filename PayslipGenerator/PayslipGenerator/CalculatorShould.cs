using System;
using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    [TestFixture]
    public class CalculatorShould
    {
        [Test]
        public void ReturnGrossIncomeForSalaryTwelveThousand()
        {
            var annualSalary = 12000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedIncome = 1000;

            Assert.AreEqual(expectedIncome, calculator.GrossIncome(annualSalary, numberOfMonths));
        }
    }
}

