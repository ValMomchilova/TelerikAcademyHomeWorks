using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Deposit : Account, IAccount
    {
        public Deposit(string iBAN, ICustomer customer, decimal interestRate)
            :base(iBAN, customer, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int monthsCount)
        {
            // Deposit accounts have no interest if their balance is positive and less than 1000.

            decimal result = 0;

            if (!(this.Balance > 0 && this.Balance < 1000))
            {
                result = base.CalculateInterestAmount(monthsCount);
            }

            return result;
        }

        public void DrawMoney(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("Draw sum can not be less that or eaqual to zero.");
            }

            this.Balance -= sum;
        }
    }
}
