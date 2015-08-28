using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public static class StudentServices
    {
        public static IEnumerable<Student> GetStudentsByGroup(IEnumerable<Student> students, byte groupNumber)
        {
             //09. Select only the students that are from group number 2.
            //• Use LINQ query. Order the students by FirstName.

            var studentsGr = from stud in students
                              where stud.GroupNumber == groupNumber
                              orderby stud.FirstName
                              select stud;

            return studentsGr;
        }

        public static IEnumerable<Student> GetStudentsByGroupExt(IEnumerable<Student> students, byte groupNumber)
        {

            //10. Implement the previous using the same query expressed with extension methods.

            var studentsGr = students.Where(stud => stud.GroupNumber == 2)
                                    .OrderBy(stud => stud.FirstName);

            return studentsGr;
        }

        public static IEnumerable<Student> GetStudentsByEmailDomain(IEnumerable<Student> students, string emailDomain)
        {

            //11. Extract all students that have email in  abv.bg .
            //• Use  string  methods and LINQ.


            var studentsDomain = from stud in students
                                 where stud.Email.Substring(stud.Email.Length - emailDomain.Length, emailDomain.Length) == emailDomain
                              select stud;

            return studentsDomain;
        }

        public static IEnumerable<Student> GetStudentsByPhoneCode(IEnumerable<Student> students, string phoneCode)
        {

            //12. Extract all students with phones in Sofia.
            //• Use LINQ.


            var studentsDomain = from stud in students
                                 where stud.Phone.Substring(0, phoneCode.Length) == phoneCode
                                 select stud;

            return studentsDomain;
        }
    }
}
