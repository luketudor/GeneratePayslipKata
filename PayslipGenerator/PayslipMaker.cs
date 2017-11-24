using System;

namespace PayslipGenerator
{
    public class PayslipMaker
    {
        private char separator;
        private Calculator calculator;

        public PayslipMaker(char fieldSeparator, Calculator payslipCalculator)
        {
            separator = fieldSeparator;
            calculator = payslipCalculator;
        }

        public string FormattedPayslip(string employeeDetails)
        {
            var employee = ParseEmployee(employeeDetails);
            var payslip = MakePayslip(employee);
            var formattedPayslip = FormatPayslip(payslip);

            return formattedPayslip;
        }

        private EmployeeDetails ParseEmployee(string employeeDetails)
        {
            var inputFields = employeeDetails.Split(separator);
            var firstName = inputFields[0];
            var lastName = inputFields[1];
            var annualSalary = int.Parse(inputFields[2]);
            var superRate = double.Parse(inputFields[3].TrimEnd('%')) / 100;
            var paymentStartDate = inputFields[4];

            return new EmployeeDetails(firstName, lastName, annualSalary, superRate, paymentStartDate);
        }

        private Payslip MakePayslip(EmployeeDetails employee)
        {
            var numberOfMonths = 12;

            var name = employee.FirstName + " " + employee.LastName;
            var payPeriod = employee.PaymentStartDate;
            var grossIncome = Convert.ToInt32(calculator.GrossIncome(employee.AnnualSalary, numberOfMonths));
            var incomeTax = Convert.ToInt32(calculator.IncomeTax(employee.AnnualSalary, numberOfMonths));
            var netIncome = Convert.ToInt32(calculator.NetIncome(grossIncome, incomeTax));
            var super = Convert.ToInt32(calculator.Super(grossIncome, employee.SuperRate));

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