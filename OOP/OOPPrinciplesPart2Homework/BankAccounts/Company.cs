using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Company : Customer, ICustomer
    {
        private string companyName;
        private string eIK;

        public Company(string companyName, string eIK, string phoneNumber, string address )
        {
            this.CompanyName = companyName;
            this.EIK = eIK;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("CompanyName can not be null or empty.");
                }

                this.companyName = value;
            }
        }

        public override CustomerType CustomerType
        {
            get
            {
                return CustomerType.Company;
            }
        }

        public override string Name
        {
            get
            {
                return this.companyName;
            }
        }

        public string EIK
        {
            get
            {
                return this.eIK;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EIK can not be null or empty.");
                }

                string trimmedValue = value.Trim();

                if (!ValidateEIK(trimmedValue))
                {
                    throw new ArgumentException("EIK format is not valid.");
                }

                this.eIK = value;
            }
        }

        private bool ValidateEIK(string value)
        {
            bool result = true;
            
            int minSymbolCount = 9;
            int maxSymbolCount = 13;

            if (value.Length < minSymbolCount || value.Length > maxSymbolCount)
            {
                result = false;
            }

            return result;
        }
    }
}

        
