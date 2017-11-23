using System;

namespace PayslipGenerator
{
    public class PayslipMaker
    {
        private int annualSalary;
        private double superRate;
        private string paymentStartDate;
        public string Name { get; }

        public PayslipMaker(string firstName, string lastName, int annualSalary, double superRate, string paymentStartDate)
        {
            Name = firstName + " " + lastName;
            this.annualSalary = annualSalary;
            this.superRate = superRate;
            this.paymentStartDate = paymentStartDate;
        }

        public int GrossIncome(Calculator calculator)
        {
            return (int)calculator.GrossIncome(annualSalary, 12);
        }
    }
}