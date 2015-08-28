using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Person: INameable
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
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
                    throw new ArgumentException("Name can not be null or empty.");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
