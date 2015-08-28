using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Loan : Account, IAccount
    {
        public Loan(string iBAN, ICustomer customer, decimal interestRate)
            :base(iBAN, customer, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int monthsCount)
        {
            // Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held 
            // by a company.

            int MonthsWithoutInterest = 0;

            if (this.Customer.CustomerType == CustomerType.Company)
            {
                MonthsWithoutInterest = 2;
            }
            else // Individual
            {
                MonthsWithoutInterest = 3;
            }
            
            monthsCount = Math.Max(monthsCount - MonthsWithoutInterest, 0);
            decimal sum = base.CalculateInterestAmount(monthsCount);

            return sum;
        }
    }
}
