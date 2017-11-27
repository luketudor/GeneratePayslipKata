using System;

namespace PayslipGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var payslipMaker = new PayslipMaker(new Calculator(new DefaultTaxTable()));
            var payslipFormatter = new PayslipParser(',');

            while(true)
            {
                Console.WriteLine("Please enter an employee to create the payslip for:");
                var employee = payslipFormatter.ParseEmployee(Console.ReadLine());
                var payslip = payslipMaker.Compute(employee);
                var formattedPayslip = payslipFormatter.Format(payslip);
                Console.WriteLine(formattedPayslip);
                Console.WriteLine();
            }
        }
    }
}
