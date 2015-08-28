using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Customer : ICustomer
    {
        private string address;
        private string phoneNumber;

        public abstract CustomerType CustomerType { get; }
        
        public abstract string Name { get; }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("CompanyName can not be null or empty.");
                }

                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Phone number cannot be Null or empty.");
                }

                string trimmedValue = value.Trim();

                if (!ValidatePhoneNumber(trimmedValue))
                {
                    throw new ArgumentException("Phone number format is not valid.");
                }

                this.phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.CustomerType, this.Name);
        }

        private bool ValidatePhoneNumber(string value)
        {
            bool result = true;

            if (value.Length < 3)
            {
                result = false;
            }
            else if (value[0] != '+' && !char.IsDigit(value[0]))
            {
                result = false;
            }
            else
            {
                for (int i = 1; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

       
    }
}
