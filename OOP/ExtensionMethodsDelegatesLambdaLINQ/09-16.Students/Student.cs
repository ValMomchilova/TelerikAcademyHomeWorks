using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Create a class  Student  with properties  FirstName ,  LastName ,  FN ,  Tel ,  Email ,  Marks  (a List),  GroupNumber .

namespace Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private byte groupNumber;
        private IEnumerable<byte> marks;

        public Student(string firstName, string lastNme, string fn)
        {
            this.FirstName = firstName;
            this.LastName = lastNme;
            this.FN = fn;
        }

        public Student(string firstName, string lastNme, string fn, string phone, string email, byte groupNumber, List<byte> marks)
            : this(firstName, lastNme, fn)
        {
            this.Phone = phone;
            this.Email = email.Trim();
            this.GroupNumber = groupNumber;
            this.marks = marks;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be Null or empty.");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be Null or empty.");
                }

                lastName = value;
            }
        }

        public string FN { get; set; }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            private set
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

                this.phone = trimmedValue;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email cannot be Null or empty.");
                }

                string trimmedValue = value.Trim();

                this.ValidateEmail(trimmedValue);
                email = trimmedValue;
            }
        }

        public byte GroupNumber
        {
            get
            {
                return groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number cannot be zero or less than zero.");
                }

                groupNumber = value;
            }
        }                

        public List<byte> Marks
        {
            get
            {
                return new List<byte>(this.marks);
            }           
        }


        public override string ToString()
        {
            return string.Format("{0} {1} FN: {2} Phone: {3} Email: {4} Gr: {5}\nMarks: {6}",
                FirstName, LastName, FN, Phone, Email, GroupNumber, string.Join(", ", Marks.ToArray()));
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

        private void ValidateEmail(string email)
        {
            if (!Regex.IsMatch(email.Trim(),
                 @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                throw new ArgumentException("Invalid email.");
            }

        }
    }
}
