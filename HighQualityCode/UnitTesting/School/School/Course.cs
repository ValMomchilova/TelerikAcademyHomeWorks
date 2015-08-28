namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {       
        public const int MaxStudentsCount = 30;

        private int number;

        private string name;

        private ICollection<Student> students;

        public Course(string name, int number)
        {
            this.Name = name;
            this.Number = number;
            this.Students = new List<Student>();
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Course number must be greater than zero");
                }

                this.number = value;
            }
        }

        public int StudentsCount
        {
            get
            {
                return this.Students.Count;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }

            protected set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.CheckIfStudentIsIncourse(student.Number))
            {
                throw new ArgumentException(string.Format("Student with student number {0} is already in the course", student.Number));
            }

            if (this.Students.Count >= MaxStudentsCount)
            {
               throw new ArgumentException(string.Format("Student count can not be more that {0}", MaxStudentsCount));
            }

            this.students.Add(student);    
        }

        public bool RemoveStudent(int studentNumber)
        {
            Student student = this.Students.FirstOrDefault(s => s.Number == studentNumber);

            if (student == null)
            {
                throw new ArgumentException(
                    string.Format("Student with student number {0} does not exist in the course", studentNumber));
            }

            bool result;
            result = this.students.Remove(student);

            return result;
        }

        public bool CheckIfStudentIsIncourse(int studentNumber)
        {
            bool result = this.Students.Any(s => s.Number == studentNumber);

            return result;
        }
    }
}
