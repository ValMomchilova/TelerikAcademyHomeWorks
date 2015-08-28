using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//• Use LINQ query operators.


namespace Students
{
    public static class StudentsHelper
    {
        public static Student[] FindStudentsWhichFirstNameIsBeforeLast(Student[] students)
        {    
            Student[] result = students
                            .Where(student => String.Compare(student.FirstName, student.LastName, StringComparison.InvariantCultureIgnoreCase) < 0)
                            .ToArray();                      
            
            return result;
        }
        

        public static string StudentsToStirng(Student[] students)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < students.Length; i++)            
            {
                sb.Append(students[i]);

                if (i < students.Length - 1)
                {
                    sb.Append('\r');
                    sb.Append('\n');
                }
            }

            return sb.ToString();
        }
    }
}
