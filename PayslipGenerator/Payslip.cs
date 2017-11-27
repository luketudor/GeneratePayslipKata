
using System;

namespace PayslipGenerator
{
    public class Payslip
    {
        public string Name { get; }
        public string PayPeriod { get; }
        public int GrossIncome { get; }
        public int IncomeTax { get; }
        public int NetIncome { get; }
        public int Super { get; }

        public Payslip(string name, string payPeriod, int grossIncome, int incomeTax, int netIncome, int super)
        {
            Name = name;
            PayPeriod = payPeriod;
            GrossIncome = grossIncome;
            IncomeTax = incomeTax;
            NetIncome = netIncome;
            Super = super;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var other = (Payslip)obj;
            return Name.Equals(other.Name) &&
                PayPeriod.Equals(other.PayPeriod) &&
                GrossIncome.Equals(other.GrossIncome) &&
                IncomeTax.Equals(other.IncomeTax) &&
                Super.Equals(other.Super);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}