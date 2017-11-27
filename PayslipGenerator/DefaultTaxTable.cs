namespace PayslipGenerator
{
    public class DefaultTaxTable : ITaxTable
    {
        public double AnnualIncomeTax(double annualSalary)
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

            return tax;
        }
    }
}