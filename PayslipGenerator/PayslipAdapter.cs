
namespace PayslipGenerator
{
    class PayslipAdapter
    {
        private char separator;

        public PayslipAdapter(char fieldSeparator)
        {
            separator = fieldSeparator;
        }

        public EmployeeDetails ParseEmployee(string employeeDetails)
        {
            var inputFields = employeeDetails.Split(separator);
            var firstName = inputFields[0];
            var lastName = inputFields[1];
            var annualSalary = int.Parse(inputFields[2]);
            var superRate = double.Parse(inputFields[3].TrimEnd('%')) / 100;
            var paymentStartDate = inputFields[4];

            return new EmployeeDetails(firstName, lastName, annualSalary, superRate, paymentStartDate);
        }

        public string Format(Payslip payslip)
        {
            return string.Join(separator.ToString(),
                payslip.Name,
                payslip.PayPeriod,
                payslip.GrossIncome,
                payslip.IncomeTax,
                payslip.NetIncome,
                payslip.Super);
        }
    }
}
