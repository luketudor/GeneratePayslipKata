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

        [Test]
        public void ReturnGrossIncomeForSalaryTwentyFourThousand()
        {
            var annualSalary = 24000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedIncome = 2000;

            Assert.AreEqual(expectedIncome, calculator.GrossIncome(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnRoundedDownGrossIncome()
        {
            var annualSalary = 10000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            // 833.33333 to be more precise
            var expectedIncome = 833;

            Assert.AreEqual(expectedIncome, calculator.GrossIncome(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnRoundedUpGrossIncome()
        {
            var annualSalary = 7;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            // 0.5833333 to be more precise
            var expectedIncome = 1;

            Assert.AreEqual(expectedIncome, calculator.GrossIncome(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnIncomeTaxForFirstTaxBracket()
        {
            var grossIncome = 10000;
            var calculator = new Calculator();

            var expectedTax = 0;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(grossIncome));
        }

        [Test]
        public void ReturnIncomeTaxForSecondTaxBracket()
        {
            var grossIncome = 20000;
            var calculator = new Calculator();

            var expectedTax = 342;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(grossIncome));
        }

        [Test]
        public void ReturnIncomeTaxForThirdTaxBracket()
        {
            var grossIncome = 40000;
            var calculator = new Calculator();

            var expectedTax = 4547;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(grossIncome));
        }

        [Test]
        public void ReturnIncomeTaxForFourthTaxBracket()
        {
            var grossIncome = 90000;
            var calculator = new Calculator();

            var expectedTax = 21247;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(grossIncome));
        }

        [Test]
        public void ReturnIncomeTaxForFifthTaxBracket()
        {
            var grossIncome = 200000;
            var calculator = new Calculator();

            var expectedTax = 63547;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(grossIncome));
        }

        [Test]
        public void ReturnRoundedIncomeTax()
        {
            var grossIncome = 123456;
            var calculator = new Calculator();

            // 33625.72 to be exact
            var expectedTax = 33626;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(grossIncome));
        }

        [Test]
        public void ReturnNetIncomeForGrossTwoThousand()
        {
            var grossIncome = 2000;
            var incomeTax = 500;
            var calculator = new Calculator();

            var expectedIncome = 1500;

            Assert.AreEqual(expectedIncome, calculator.NetIncome(grossIncome, incomeTax));
        }

        [Test]
        public void ReturnNetIncomeForGrossFiveFourThreeTwoOne()
        {
            var grossIncome = 54321;
            var incomeTax = 14417;
            var calculator = new Calculator();

            var expectedIncome = 39904;

            Assert.AreEqual(expectedIncome, calculator.NetIncome(grossIncome, incomeTax));
        }

        [Test]
        public void ReturnRoundedUpSuper()
        {
            var grossIncome = 4735;
            var superRate = 0.1226;
            var calculator = new Calculator();

            // 580.511 to be exact
            var expectedIncome = 581;

            Assert.AreEqual(expectedIncome, calculator.Super(grossIncome, superRate));
        }

        [Test]
        public void ReturnRoundedDownSuper()
        {
            var grossIncome = 12944;
            var superRate = 0.0765;
            var calculator = new Calculator();

            // 990.216 to be exact
            var expectedIncome = 990;

            Assert.AreEqual(expectedIncome, calculator.Super(grossIncome, superRate));
        }
    }
}

