using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class  Person  with two fields – name and age. Age can be left unspecified 
//    (may contain  null  value. Override  ToString()  to display the information of a person and if age is not specified – to say so.
//• Write a program to test this functionality.

namespace PersonClass
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;       
        }

        public Person(string name, int? age)
            :this(name)
        {          
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be null or empty");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Age: {1}", this.Name, this.Age == null ? "Not specified" : this.Age.ToString());
        }
    }
}
