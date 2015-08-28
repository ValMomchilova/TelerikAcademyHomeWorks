using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class SchoolClass : ICommentable
    {
        private string nameID;
        private string comment;
        private List<Teacher> teachers;
        private List<Student> students;

        public SchoolClass(string nameID)
        {
            this.NameID = nameID;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public string NameID
        {
            get
            {
                return this.nameID;
            }
            set
            {
                this.nameID = value;
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

        public IList<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(teachers);
            }   
        }

        public IList<Student> Students
        {
            get
            {
                return new List<Student>(students);
            }           
        }

        public void AddTeacher(Teacher teacher)
        {

            this.teachers.Add(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void DeleteTeacher(int teacherIndex)
        {
            this.teachers.RemoveAt(teacherIndex);
        }

        public void ClearTeachers()
        {
            this.teachers.Clear();
        }

        public void AddStudent(Student student)
        {
            if (this.students.Any(stud => stud.ClassNumber == student.ClassNumber))
            {
                throw new ArgumentException(
                    String.Format("Student ClassNumber must be unique. There is already defined Student having ClassNumber {0}"
                    , student.ClassNumber));
            }

            this.students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void DeleteStudent(int studentIndex)
        {
            this.students.RemoveAt(studentIndex);
        }

        public void ClearStudents()
        {
            this.students.Clear();
        }

        public Student GetStudentByClassNumber(int classNumber)
        {
            Student result = this.students
                .FirstOrDefault(stud => stud.ClassNumber == classNumber);

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Class {0}", this.NameID));
            sb.AppendLine("Students:");
            this.Students.OrderBy(st => st.Name);

            foreach (var item in this.Students)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Teachers:");
            this.Teachers.OrderBy(t => t.Name);

            foreach (var item in this.Teachers)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }
    }
}
