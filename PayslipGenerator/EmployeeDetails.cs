using System;

namespace PayslipGenerator
{
    public class EmployeeDetails
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int AnnualSalary { get; }
        public double SuperRate { get; }
        public string PaymentStartDate { get; }

        public EmployeeDetails(string firstName, string lastName, int annualSalary, double superRate, string paymentStartDate)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
            PaymentStartDate = paymentStartDate;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var other = (EmployeeDetails)obj;

            return FirstName.Equals(other.FirstName) &&
                LastName.Equals(other.LastName) &&
                AnnualSalary.Equals(other.AnnualSalary) &&
                SuperRate.Equals(other.SuperRate) &&
                PaymentStartDate.Equals(other.PaymentStartDate);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}