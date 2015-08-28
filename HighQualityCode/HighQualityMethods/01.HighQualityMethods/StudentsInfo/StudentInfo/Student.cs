namespace StudentInfo
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {         
            this.FirstName = firstName;
            this.LastName = lastName;
        }       

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }

            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("firstName");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("firstName can not be empty");
                }

                this.firstName = value; 
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
                if (value == null)
                {
                    throw new ArgumentNullException("lastName");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("lastName can not be empty");
                }

                this.lastName = value; 
            }
        }
            
        public DateTime DateOfBirth { get; set; }

        public string Town { get; set; }

        public string Interest { get; set; }

        public CourseResult CourseResult { get; set; } 

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = other.DateOfBirth; 

            bool isOlderThan = firstDate < secondDate;

            return isOlderThan;
        }
    }
}
