using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Define a class  Student , which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail,
//course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//• Override the standard methods, inherited by  System.Object :  Equals() ,  ToString() ,  GetHashCode()  and operators  ==  and  != .

//02. IClonable
//• Add implementations of the  ICloneable  interface.
//The  Clone()  method should deeply copy all object's fields into a new object of type  Student .

//3. IComparable
//• Implement the  IComparable<Student>  interface to compare students by names (as first criteria, in lexicographic order) 
//and by social security number (as second criteria, in increasing order).


namespace StudentClass
{
    public class Student: ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string sSN;
        private string address;
        private string mobilePhone;
        private string email;
        private byte course;

        public Student(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public Student(string firstName, string middleName,
                string lastName, string sSN, string address, string mobilePhone, string email, byte course,
                Specialty specialty, Faculty faculty, University university)
            : this(firstName, middleName, lastName)
        {
            this.SSN = sSN;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = specialty;
            this.Faculty = faculty;
            this.University = university;
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
                    throw new ArgumentException("First name can not be null or empty");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Middle name can not be null or empty");
                }

                this.middleName = value;
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
                    throw new ArgumentException("Last name can not be null or empty");
                }

                this.lastName = value;
            }
        }

        public string Name
        {
            get
            {
                return string.Format("{0}, {1}, {2}", this.FirstName, this.MiddleName, this.LastName);
            }            
        }

        public string SSN
        {
            get
            {
                return this.sSN;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("SSN cannot be Null or empty.");
                }

                string trimmedValue = value.Trim();

                if (!ValidateSSN(trimmedValue))
                {
                    throw new ArgumentException("SSN format is not valid.");
                }

                this.sSN = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mobile phone number cannot be Null or empty.");
                }

                string trimmedValue = value.Trim();

                if (!ValidatePhoneNumber(trimmedValue))
                {
                    throw new ArgumentException("Mobile phone format is not valid.");
                }

                this.mobilePhone = value;
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

        public byte Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public Specialty Speciality { get; set; }

        public Faculty Faculty { get; set; }

        public University University { get; set; }

        public override bool Equals(object obj)
        {
            bool result = true;

            if (!this.FirstName.Equals((obj as Student).FirstName))
            {
                result = false;
            }

            if (!this.MiddleName.Equals((obj as Student).MiddleName))
            {
                result = false;
            }

            if (!this.LastName.Equals((obj as Student).LastName))
            {
                result = false;
            }
            if (!this.SSN.Equals((obj as Student).SSN))
            {
                result = false;
            }

            if (!this.MobilePhone.Equals((obj as Student).MobilePhone))
            {
                result = false;
            }

            if (!this.Address.Equals((obj as Student).Address))
            {
                result = false;
            }

            if (!this.Course.Equals((obj as Student).Course))
            {
                result = false;
            }

            if (!this.Email.Equals((obj as Student).Email))
            {
                result = false;
            }

            if (!this.Course.Equals((obj as Student).Course))
            {
                result = false;
            }
            if (!this.Faculty.Equals((obj as Student).Faculty))
            {
                result = false;
            }

            if (!this.University.Equals((obj as Student).University))
            {
                result = false;
            }

            if (!this.Speciality.Equals((obj as Student).Speciality))
            {
                result = false;
            }


            return result;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1.Equals(student2));
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode()
                 ^ this.FirstName.GetHashCode()
                 ^ this.LastName.GetHashCode()
                 ^ this.University.ToString().GetHashCode();
        }        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            sb.AppendLine(String.Format("SSN: {0}", this.SSN));
            sb.AppendLine(String.Format("Address: {0}", this.Address));
            sb.AppendLine(String.Format("Phone: {0}", this.MobilePhone));
            sb.AppendLine(String.Format("Email: {0}", this.Email));
            sb.AppendLine(String.Format("University: {0} \nFaculty: {1}, Speciality: {2}, Course: {3}",
                this.University.DescriptionToString(), this.Faculty.DescriptionToString(), this.Speciality.DescriptionToString(),
                this.Course));

            return sb.ToString();
        }

        public object Clone()
        {
            Student newStudent = new Student((string)this.FirstName.Clone(),
                                             (string)this.MiddleName.Clone(),
                                             (string)this.LastName.Clone(),
                                             (string)this.SSN.Clone(),
                                             (string)this.Address.Clone(),
                                             (string)this.MobilePhone.Clone(),
                                             (string)this.Email.Clone(),
                                             this.Course,
                                             this.Speciality, this.Faculty, this.University);

            return newStudent;
        }

        public int CompareTo(Student other)
        {
            int result = this.Name.CompareTo(other.Name);

            if(result == 0)
            {
                result = this.SSN.CompareTo(other.SSN);
            }

            return result;
        }

        private bool ValidatePhoneNumber(string value)
        {
            bool result = true;

            if (value.Length < 10)
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

        private bool ValidateSSN(string value)
        {
            bool result = true;

            if (value.Length != 9)
            {
                result = false;
            }           
            else
            {
                for (int i = 0; i < value.Length; i++)
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

