using System;

namespace PayslipGenerator
{
    public class PayslipMaker
    {
        private readonly Calculator _calculator;

        public PayslipMaker(Calculator payslipCalculator)
        {
            _calculator = payslipCalculator;
        }

        public Payslip Compute(EmployeeDetails employee)
        {
            const int numberOfMonths = 12;

            var name = employee.FirstName + " " + employee.LastName;
            var payPeriod = employee.PaymentStartDate;
            var grossIncome = Convert.ToInt32(_calculator.GrossIncome(employee.AnnualSalary, numberOfMonths));
            var incomeTax = Convert.ToInt32(_calculator.IncomeTax(employee.AnnualSalary, numberOfMonths));
            var netIncome = Convert.ToInt32(_calculator.NetIncome(grossIncome, incomeTax));
            var super = Convert.ToInt32(_calculator.Super(grossIncome, employee.SuperRate));

            return new Payslip(name, payPeriod, grossIncome, incomeTax, netIncome, super);
        }
    }
}