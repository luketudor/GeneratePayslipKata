using System;

namespace PayslipGenerator
{
    public class Calculator
    {

        public double GrossIncome(double annualSalary, double numberOfMonths)
        {
            return Math.Round(annualSalary / numberOfMonths);
        }

        public double IncomeTax(double grossIncome)
        {
            var tax = 0.0;
            if (grossIncome <= 18200)
            {
                tax = 0;
            }
            else if (grossIncome <= 37000)
            {
                tax = (grossIncome - 18200) * 0.19;
            }
            else if (grossIncome <= 80000)
            {
                tax = (grossIncome - 37000) * 0.325 + 3572;
            }
            else if (grossIncome <= 180000)
            {
                tax = (grossIncome - 80000) * 0.37 + 17547;
            }
            else
            {
                tax = (grossIncome - 180000) * 0.45 + 54547;
            }
            return Math.Round(tax);
        }

        public double NetIncome(double grossIncome, double incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public double Super(double grossIncome, double superRate)
        {
            return Math.Round(grossIncome * superRate);
        }
    }
}

