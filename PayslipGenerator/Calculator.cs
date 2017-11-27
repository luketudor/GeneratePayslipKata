using System;

namespace PayslipGenerator
{
    public class Calculator
    {
        private readonly ITaxTable _taxTable;
        private readonly MidpointRounding _midpointRounding;

        public Calculator(ITaxTable taxTable)
        {
            _taxTable = taxTable;
            _midpointRounding = MidpointRounding.AwayFromZero;
        }

        public double GrossIncome(double annualSalary, int numberOfPaySections)
        {
            return Math.Round(annualSalary / numberOfPaySections, _midpointRounding);
        }

        public double IncomeTax(double annualSalary, int numberOfPaySections)
        {
            return Math.Round(_taxTable.AnnualIncomeTax(annualSalary) / numberOfPaySections, _midpointRounding);
        }

        public double NetIncome(double grossIncome, double incomeTax)
        {
            return Math.Round(grossIncome - incomeTax, _midpointRounding);
        }

        public double Super(double grossIncome, double superRate)
        {
            return Math.Round(grossIncome * superRate, _midpointRounding);
        }
    }
}