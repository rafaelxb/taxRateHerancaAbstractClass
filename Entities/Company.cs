using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxRate.Entities
{
    internal class Company : Payer

    {
        public int EmployeesNumber { get; set; }
        public Company(string name, double annualIncome, int employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double taxesPaid()
        {
            double taxToPay;

            if (EmployeesNumber > 10)
            {
                taxToPay = AnnualIncome * 0.14;
            }
            else
            {
                taxToPay = AnnualIncome * 0.16;
            }

            return taxToPay;
        }
    }
}
