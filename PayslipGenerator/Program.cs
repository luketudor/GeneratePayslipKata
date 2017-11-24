using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var payslipMaker = new PayslipMaker(',', new Calculator());

            while(true)
            {
                Console.WriteLine("Please enter an employee to create the payslip for:");
                string payslip = payslipMaker.FormattedPayslip(Console.ReadLine());
                Console.WriteLine(payslip);
                Console.WriteLine();
            }
        }
    }
}
