namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestSchool
    {
        [TestMethod]
        public void EnsureCourseCanBeAddedToScholl()
        {
            int number = 1;
            string name = "C#";
            Course course = new Course(name, number);

            School school = new School();
            school.AddCourse(course);

            Assert.AreEqual(school.CoursesCount, 1, "Courses count is not expected value.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureCourseCanBeAddedToSchollMoreThanOnce()
        {
            int number = 1;
            string name = "C#";
            Course course = new Course(name, number);

            School school = new School();
            school.AddCourse(course);
            school.AddCourse(course);           
        }

        [TestMethod]
        public void EnsureCourseCanBeRemovedFromScholl()
        {
            int number = 1;
            string name = "C#";
            Course course = new Course(name, number);

            School school = new School();
            school.AddCourse(course);

            int number2 = 2;
            string name2 = "OOP";
            Course course2 = new Course(name2, number2);

            school.AddCourse(course2);

            Assert.AreEqual(school.CoursesCount, 2, "Courses count is not expected value.");

            school.RemoveCourse(1);
            Assert.AreEqual(school.CoursesCount, 1, "Courses count is not expected value after remove.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureThereIsExceptionIfTryToRemoveUnexistingCourse()
        {
            int number = 1;
            string name = "C#";
            Course course = new Course(name, number);

            School school = new School();
            school.AddCourse(course);

            int number2 = 2;
            string name2 = "OOP";
            Course course2 = new Course(name2, number2);

            school.AddCourse(course2);

            school.RemoveCourse(3);          
        }
    }
}
