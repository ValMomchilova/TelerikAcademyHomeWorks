using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A  bank  holds different types of accounts for its customers:  deposit  accounts,  loan  accounts and  mortgage  accounts. Customers could be
//individuals  or  companies .
//• All accounts have customer, balance and interest rate (monthly based). ◦ Deposit accounts are allowed to deposit and with draw money.
//◦ Loan and mortgage accounts can only deposit money.
//• All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows:
//number_of_months  *  interest_rate .
//• Loan accounts have no interest for the first  3  months if are held by individuals and for the first  2  months if are held by a company.
//• Deposit accounts have no interest if their balance is positive and less than  1000 .
//• Mortgage accounts have ½ interest for the first  12  months for companies and no interest for the first  6  months for individuals.
//• Your task is to write a program to model the bank system by classes and interfaces.
//• You should identify the classes, interfaces, base classes and abstract actions and implement the calculation 
//of the interest functionality through overridden methods.


namespace BankAccounts
{
    class BankAccountsTest
    {
        static void Main()
        {
            Account[] bankAccounts = new Account[6];
            bankAccounts[0] = new Deposit("BG13IORT73778100610012",
                new Individual("Deljan", "Stojanov", "Zlatev", "9801062347", "0899745657", "Varna"), 0.007m);
            bankAccounts[0].DepositMoney(900m);
            ((Deposit)bankAccounts[0]).DrawMoney(100m);

            bankAccounts[1] = new Deposit("BG13IORT73778100610000",
                new Company("Dimo DZZD", "457456789", "0897234587", "Sofia"), 0.009m);
            bankAccounts[1].DepositMoney(2000m);

            bankAccounts[2] = new Loan("BG13IORT73778100610032",
                new Individual("Stefan", "Zlatev", "Bojanov", "9801062347", "0899745612", "Sofia"), 0.008m);
            bankAccounts[2].DepositMoney(1000m);

            bankAccounts[3] = new Loan("BG90IORT73778500650000",
                new Company("AAA OOD", "985456789", "0897234587", "Sofia"), 0.009m);
            bankAccounts[3].DepositMoney(1000m);

            bankAccounts[4] = new Mortgage("BG13IORT73778100610078",
                new Individual("Zlatina", "Givkova", "Zlateva", "9801062347", "0899745678", "Varna"), 0.005m);
            bankAccounts[4].DepositMoney(1000m);

            bankAccounts[5] = new Mortgage("BG85IORT73778600660000",
                new Company("BBB EOOD", "478456789", "0897234512", "Varna"), 0.009m);
            bankAccounts[5].DepositMoney(1000m);

            Console.WriteLine("Interest amount is calculated for 12 months:");
            Console.WriteLine();
            
            foreach (var item in bankAccounts)
            {
                Console.WriteLine("{0} \nInterest: {1:F2}", item, item.CalculateInterestAmount(12));
            }
        }
    }
}
