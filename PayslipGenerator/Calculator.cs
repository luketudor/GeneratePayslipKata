using System;

namespace PayslipGenerator
{
    public class Calculator
    {

        public double GrossIncome(double annualSalary, int numberOfPaySections)
        {
            return Math.Round(annualSalary / numberOfPaySections, MidpointRounding.AwayFromZero);
        }

        public double IncomeTax(double annualSalary, int numberOfPaySections)
        {
            var tax = 0.0;
            if (annualSalary <= 18200)
            {
                tax = 0;
            }
            else if (annualSalary <= 37000)
            {
                tax = (annualSalary - 18200) * 0.19;
            }
            else if (annualSalary <= 80000)
            {
                tax = (annualSalary - 37000) * 0.325 + 3572;
            }
            else if (annualSalary <= 180000)
            {
                tax = (annualSalary - 80000) * 0.37 + 17547;
            }
            else
            {
                tax = (annualSalary - 180000) * 0.45 + 54547;
            }
            return Math.Round(tax / numberOfPaySections, MidpointRounding.AwayFromZero);
        }

        public double NetIncome(double grossIncome, double incomeTax)
        {
            return Math.Round(grossIncome - incomeTax, MidpointRounding.AwayFromZero);
        }

        public double Super(double grossIncome, double superRate)
        {
            return Math.Round(grossIncome * superRate, MidpointRounding.AwayFromZero);
        }
    }
}

