
namespace PayslipGenerator
{
    public class PayslipMaker
    {
        private char separator;
        private Calculator calculator;

        public PayslipMaker(char payslipFieldSeparator)
        {
            separator = payslipFieldSeparator;
            calculator = new Calculator();
        }

        public string Compute(string employeeDetails)
        {
            var employee = ParseEmployee(employeeDetails);
            var payslip = MakePayslip(employee);
            var formattedPayslip = FormatPayslip(payslip);

            return formattedPayslip;
        }

        private Employee ParseEmployee(string employeeDetails)
        {
            var inputFields = employeeDetails.Split(separator);
            var firstName = inputFields[0];
            var lastName = inputFields[1];
            var annualSalary = int.Parse(inputFields[2]);
            var superRate = double.Parse(inputFields[3].TrimEnd('%')) / 100;
            var paymentStartDate = inputFields[4];

            return new Employee(firstName, lastName, annualSalary, superRate, paymentStartDate);
        }

        private Payslip MakePayslip(Employee employee)
        {
            var name = employee.FirstName + " " + employee.LastName;
            var payPeriod = employee.PaymentStartDate;
            var grossIncome = (int)calculator.GrossIncome(employee.AnnualSalary, 12);
            var incomeTax = (int)calculator.IncomeTax(employee.AnnualSalary, 12);
            var netIncome = (int)calculator.NetIncome(grossIncome, incomeTax);
            var super = (int)calculator.Super(grossIncome, employee.SuperRate);

            return new Payslip(name, payPeriod, grossIncome, incomeTax, netIncome, super);
        }

        private string FormatPayslip(Payslip payslip)
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