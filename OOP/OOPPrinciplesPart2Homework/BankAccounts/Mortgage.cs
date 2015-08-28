using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Mortgage : Account, IAccount
    {
        public Mortgage(string iBAN, ICustomer customer, decimal interestRate)
            : base(iBAN, customer, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int monthsCount)
        {
            // Mortgage accounts have ½ interest for the first 12 months for companies 
            // and no interest for the first 6 months for individuals.

            decimal sum = 0;

            if (this.Customer.CustomerType == CustomerType.Company)
            {
                int fullInterestPeriod = Math.Max(monthsCount - 12, 0);
                int halfInterestPeriod = Math.Min(monthsCount, 12);
                sum = base.CalculateInterestAmount(fullInterestPeriod) +
                    base.CalculateInterestAmount(halfInterestPeriod) / 2;
            }
            else // individual
            {
                monthsCount = Math.Max(monthsCount - 6, 0);
                sum = base.CalculateInterestAmount(monthsCount);
            }

            return sum;
        }
    }
}
