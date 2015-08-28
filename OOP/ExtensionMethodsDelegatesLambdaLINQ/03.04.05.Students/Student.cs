using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public Student(string firstName, string lastNme, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastNme;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, LastName, Age);
        }
    }
}
