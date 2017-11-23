using System;

namespace PayslipGenerator
{
    public class Payslip
    {
        private string firstName;
        private string lastName;
        private object annualSalary;
        private object superRate;
        private object paymentStartDate;

        public Payslip(string firstName, string lastName, object annualSalary, object superRate, object paymentStartDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.annualSalary = annualSalary;
            this.superRate = superRate;
            this.paymentStartDate = paymentStartDate;
        }

        public string Name()
        {
            return "Foo Bar";
        }
    }
}