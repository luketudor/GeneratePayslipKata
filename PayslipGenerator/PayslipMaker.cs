﻿using System;

namespace PayslipGenerator
{
    public class PayslipMaker
    {

        public string Compute(string employeeDetails)
        {
            var calculator = new Calculator();

            var detailFields = employeeDetails.Split(',');
            var firstName = detailFields[0];
            var lastName = detailFields[1];
            var annualSalary = int.Parse(detailFields[2]);
            var superRate = double.Parse(detailFields[3].TrimEnd('%')) / 100;
            var paymentStartDate = detailFields[4];

            var name = firstName + " " + lastName;
            var payPeriod = paymentStartDate;
            var grossIncome = (int)calculator.GrossIncome(annualSalary, 12);
            var incomeTax = (int)calculator.IncomeTax(annualSalary, 12);
            var netIncome = (int)calculator.NetIncome(grossIncome, incomeTax);
            var super = (int)calculator.Super(grossIncome, superRate);

            return name + ',' + payPeriod + ',' + grossIncome + ',' + incomeTax + ',' + netIncome + ',' + super;
        }
    }
}