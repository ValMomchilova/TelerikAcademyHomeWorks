namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<Course> courses;

        public School()
        {
            this.Courses = new List<Course>();
        }

        public int CoursesCount
        {
            get
            {
                return this.Courses.Count;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }

            protected set
            {
                this.courses = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (this.CheckIfCourseIsInSchool(course.Number))
            {
                throw new ArgumentException(string.Format(
                    "Course with number {0} is already in the school", course.Name));
            }          

            this.courses.Add(course);
        }

        public bool RemoveCourse(int courseNumber)
        {
            Course course = this.Courses.FirstOrDefault(s => s.Number == courseNumber);

            if (course == null)
            {
                throw new ArgumentException(
                    string.Format("Course with number {0} does not exist in the school", courseNumber));
            }

            bool result;
            result = this.courses.Remove(course);

            return result;
        }

        public bool CheckIfCourseIsInSchool(int courseNumber)
        {
            bool result = this.Courses.Any(s => s.Number == courseNumber);

            return result;
        }
    }
}
