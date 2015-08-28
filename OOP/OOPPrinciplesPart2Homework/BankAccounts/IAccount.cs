using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public interface IAccount
    {
        string IBAN {get; set;}

        ICustomer Customer {get; set;}

        decimal Balance {get;}

        decimal InterestRate {get; set;}

        void DepositMoney(decimal sum);

        decimal CalculateInterestAmount(int monthsCount); 
    }
}
