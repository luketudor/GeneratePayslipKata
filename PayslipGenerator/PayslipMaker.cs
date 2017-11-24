using System;

namespace PayslipGenerator
{
    public class PayslipMaker
    {
        private Calculator calculator;

        public PayslipMaker(Calculator payslipCalculator)
        {
            calculator = payslipCalculator;
        }

        public Payslip Compute(EmployeeDetails employee)
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

    }
}