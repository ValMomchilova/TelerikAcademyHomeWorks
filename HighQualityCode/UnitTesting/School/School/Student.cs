namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public const int MinStudentNumber = 10000;
        public const int MaxStudentNumber = 99999;

        private string name;

        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name
        {
            get
            {
                return this.name; 
            }

            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty");
                }

                this.name = value; 
            }
        }        

        public int Number
        {
            get
            { 
                return this.number; 
            }

            set
            {
                if (value < MinStudentNumber || value > MaxStudentNumber)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Number must be between {0} and {1}", MinStudentNumber, MaxStudentNumber));
                }

                this.number = value;
            }
        }        
    }
}
