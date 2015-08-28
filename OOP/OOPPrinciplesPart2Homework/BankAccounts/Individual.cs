using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Individual : Customer, ICustomer
    {
        private string firstName;
        private string surname;
        private string lastName;
        private string eGN;

        public Individual(string firstName, string surname, string lastName, string eGN, string phoneNumber, string address)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            this.EGN = eGN;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName can not be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Surname can not be null or empty.");
                }

                this.surname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName can not be null or empty.");
                }

                this.lastName = value;
            }
        }

        public override CustomerType CustomerType
        {
            get
            {
                return CustomerType.Individual;
            }
        }

        public override string Name
        {
            get
            {
                return String.Format("{0}, {1}, {2}", this.FirstName, this.Surname, this.LastName);
            }
        }

        public string EGN
        {
            get
            {
                return this.eGN;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EGN can not be null or empty.");
                }

                string trimmedValue = value.Trim();

                if (!ValidateEIK(trimmedValue))
                {
                    throw new ArgumentException("EGN format is not valid.");
                }

                this.eGN = value;
            }
        }

        private bool ValidateEIK(string value)
        {
            bool result = true;

            int symbolCount = 10;

            if (value.Length != symbolCount)
            {
                result = false;
            }

            return result;
        }

       
    }
}

        


