using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account : IAccount
    {
        private string iBAN;
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(string iBAN, ICustomer customer, decimal interestRate)
        {
            this.IBAN = iBAN;
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        public string IBAN
        {
            get
            {
                return this.iBAN;
            }
            set
            {
                string trimmedValue = value.Trim();

                if (!ValidateIBAN(trimmedValue))
                {
                    throw new ArgumentException("IBAN format is not valid.");
                }

                this.iBAN = value;
            }
        }

        public ICustomer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("InterestRate can not be less that zero.");
                }

                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("Deposit sum can not be less that or eaqual to zero.");
            }

            this.Balance += sum;
        }       

        public virtual decimal CalculateInterestAmount(int monthsCount)
        {
            decimal sum = monthsCount * this.InterestRate * Math.Abs(this.Balance);           
            return sum;
        }

        public override string ToString()
        {
            return String.Format("IBAN: {0} {1}, Customer: {2}, Balance: {3:F2}, InterestRate: {4:F3}",
                this.IBAN, this.GetType().Name, this.Customer, this.Balance, this.InterestRate);
        }

        private bool ValidateIBAN(string value)
        {
            bool result = true;

            int symbolCount = 22;

            if (value.Length != symbolCount)
            {
                result = false;
            }

            foreach (var symbol in value)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
