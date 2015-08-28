namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;

        private IList<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName)
            : this(courseName)
        {           
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {            
            this.Students = students;
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
       
        public string TeacherName { get; set; }       

        public IList<string> Students
        {
            get 
            {
                return students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students");
                }

                students = new List<string>();
                for (int i = 0; i < value.Count; i++)
                {
                    students.Add(value[i]);
                }
            }
        }
        

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
