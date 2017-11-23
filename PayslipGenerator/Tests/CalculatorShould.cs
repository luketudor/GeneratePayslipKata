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

            var expectedIncome = 833;

            Assert.AreEqual(expectedIncome, calculator.GrossIncome(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnRoundedUpGrossIncome()
        {
            var annualSalary = 7;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedIncome = 1;

            Assert.AreEqual(expectedIncome, calculator.GrossIncome(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnIncomeTaxForFirstTaxBracket()
        {
            var annualSalary = 10000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedTax = 0;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnIncomeTaxForSecondTaxBracket()
        {
            var annualSalary = 20000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedTax = 29;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnIncomeTaxForThirdTaxBracket()
        {
            var annualSalary = 40000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedTax = 379;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnIncomeTaxForFourthTaxBracket()
        {
            var annualSalary = 90000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedTax = 1771;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(annualSalary, numberOfMonths));
        }

        [Test]
        public void ReturnIncomeTaxForFifthTaxBracket()
        {
            var annualSalary = 200000;
            var numberOfMonths = 12;
            var calculator = new Calculator();

            var expectedTax = 5296;

            Assert.AreEqual(expectedTax, calculator.IncomeTax(annualSalary, numberOfMonths));
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

