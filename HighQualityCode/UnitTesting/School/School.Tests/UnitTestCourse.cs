namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestCourse
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnsureCourseNameCanNotBeNull()
        {
            int number = 1;
            Course course = new Course(null, number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureCourseNameCanNotBeEmpty()
        {
            int number = 1;
            Course course = new Course(string.Empty, number);
        }

        [TestMethod]
        public void EnsureCourseNotEmptyNameIsAssigned()
        {
            int number = 1;
            string name = "C#";
            Course course = new Course(name, number);

            Assert.AreEqual(course.Name, name, "Course name is not the same as the passed name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureCourseNumberCanNotAcceptValuesLessNonPositiveValues()
        {
            int number = -1;
            string name = "C#";

            Course course = new Course(name, number);
        }

        [TestMethod]
        public void EnsureCourseNumberIsCorrect()
        {
            int number = 1;
            string name = "C#";

            Course course = new Course(name, number);

            Assert.AreEqual(course.Number, number, "The course number is not the same as assigned number");
        }

        [TestMethod]
        public void EnsureMaxCountOfStudentsIsPositive()
        {
            int maxNumber = Course.MaxStudentsCount;

            Assert.IsTrue(maxNumber > 0, "Course.MaxStudentsCount is not a positive number");
        }

        public void EnsureCourseCanBeAddedCorrectly()
        {
            int number = Student.MinStudentNumber;
            string name = "Ivan";

            Student student = new Student(name, number);
            Course course = new Course("C#", 1);

            course.AddStudent(student);

            Assert.AreEqual(course.StudentsCount, 1, "Students count is not the expected value");
            List<Student> students = (List<Student>)course.Students;
            Assert.AreEqual(students[0].Name, name, "The name of the first student is not the same as the assigned name.");
            Assert.AreEqual(students[0].Number, number, "The number of the first student is not the same as the assigned number."); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureStudentCanNotBeAddedMoreThanOnce()
        {
            int number = Student.MinStudentNumber;
            string name = "Ivan";

            Student student = new Student(name, number);
            Course course = new Course("C#", 1);

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureMoreThanMaxStudentsNumberCanNotBeAddedToCourse()
        {
            int maxStudentsCount = Course.MaxStudentsCount;

            Course course = new Course("C#", 1);

            int number = Student.MinStudentNumber;

            for (int i = 0; i <= maxStudentsCount; i++)
            {
                Student student = new Student(string.Format("student{0}", i), number);
                course.AddStudent(student);
                number++;
            }
        }

        [TestMethod]        
        public void EnsureMaxStudentsNumberCanBeAddedToCourse()
        {
            int maxStudentsCount = Course.MaxStudentsCount;

            Course course = new Course("C#", 1);

            int number = Student.MinStudentNumber;

            for (int i = 0; i < maxStudentsCount; i++)
            {
                Student student = new Student(string.Format("student{0}", i), number);
                course.AddStudent(student);
                number++;
            }

            Assert.AreEqual(
                course.StudentsCount,
                maxStudentsCount,
                "Students number is not eaqual to added students number. MaxStudentsCount are added");
        }

        [TestMethod]
        public void EnsureStudentsCanBeRemovedFromTheCourse()
        {            
            Course course = new Course("C#", 1);

            int number1 = Student.MinStudentNumber;
            Student student = new Student("Ivan", number1);
            course.AddStudent(student);

            int number2 = Student.MinStudentNumber + 1;
            Student student2 = new Student("Stojan", number2);
            course.AddStudent(student2);

            course.RemoveStudent(number1);            

            Assert.AreEqual(
                course.StudentsCount,
                1,
                "Students number is not eaqual to expected students number. 2 are added. 1 removed. expected count: 1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EEnsureThereIsExceptionIfTryToRemoveUnexistingStudent()
        {
            Course course = new Course("C#", 1);

            int number1 = Student.MinStudentNumber;
            Student student = new Student("Ivan", number1);
            course.AddStudent(student);

            int number2 = Student.MinStudentNumber + 1;
            Student student2 = new Student("Stojan", number2);
            course.AddStudent(student2);

            course.RemoveStudent(number1 + 2);           
        }
    }
}
