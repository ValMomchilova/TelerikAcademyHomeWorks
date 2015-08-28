using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public Student(string firstName, string lastName, int grade)
            : this(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Grade can not be less that one");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            string result;
            result = string.Format("{0} grade: {1}", base.ToString(), this.Grade);
            return result;
        }        
    }
}
