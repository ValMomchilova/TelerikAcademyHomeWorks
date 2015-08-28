using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student : Person, ICommentable
    {
        private int classNumber;
        private string comment;

        public Student(string name)
            : base(name)
        {

        }

        public Student(string name, int classNumber)
            : this(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}", this.classNumber, this.Name);
        }
    }
}
