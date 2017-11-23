using NUnit.Framework;

namespace PayslipGenerator.Tests
{
    [TestFixture]
    public class PayslipShould
    {

        [Test]
        public void ReturnsFirstAndLastName() 
        {
            var firstName = "Foo";
            var lastName = "Bar";
            var payslip = new Payslip(firstName, lastName, null, null, null);

            var expectedName = "Foo Bar";

            Assert.AreEqual(expectedName, payslip.Name());
        }
    }
}
