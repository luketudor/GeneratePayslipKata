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
    }
}