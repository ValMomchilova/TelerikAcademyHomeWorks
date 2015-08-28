namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureStudentNumberCanNotAcceptValuesLessThanMinStudentNumber()
        {
            int number = Student.MinStudentNumber;

            Student student = new Student("Ivan", number - 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureStudentNumberCanNotAcceptValuesGreaterThanMaxStudentNumber()
        {
            int number = Student.MaxStudentNumber;

            Student student = new Student("Ivan", number + 1);
        }

        [TestMethod]       
        public void EnsureStudentNumberCanAcceptValuesEaqualToMinStudentNumber()
        {
            int number = Student.MinStudentNumber;

            Student student = new Student("Ivan", number);

            Assert.AreEqual(student.Number, number, "Student number is not the same as assigned MinStudentNumber");
        }

        [TestMethod]        
        public void EnsureStudentNumberCanAcceptValuesEaqualToMaxStudentNumber()
        {
            int number = Student.MaxStudentNumber;

            Student student = new Student("Ivan", number);

            Assert.AreEqual(student.Number, number, "Student number is not the same as assigned MaxStudentNumber");   
        }

        [TestMethod]        
        public void EnsureStudentNumberCanAcceptValuesBetweenMinAndMaxStudentNumber()
        {
            int minNumber = Student.MinStudentNumber;
            int maxNumber = Student.MaxStudentNumber;

            Assert.IsTrue(minNumber < maxNumber, "Student.MinStudentNumber is not less than Student.MaxStudentNumber");

            int number = minNumber + 1;
            Student student = new Student("Ivan", number);

            Assert.AreEqual(student.Number, number, "Student number is not the same as assigned");                
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnsureStudentNameCanNotBeNull()
        {
            int number = Student.MinStudentNumber;
            Student student = new Student(null, number);   
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureStudentNameCanNotBeEmpty()
        {
            int number = Student.MinStudentNumber;
            Student student = new Student(string.Empty, number);
        }

        [TestMethod]        
        public void EnsureStudentNotEmptyNameIsAssigned()
        {
            int number = Student.MinStudentNumber;
            string name = "Stojan";
            Student student = new Student(name, number);

            Assert.AreEqual(student.Name, name, "Student name is not the same as the passed name");
        }
    }
}
