using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentsTest
    {
        static void Main()
        {
            //09. Create a  List<Student>  with sample students. Select only the students that are from group number 2.
            //• Use LINQ query. Order the students by FirstName.

            List<Student> students = new List<Student>();
            List<byte> marks = new List<byte>() {5, 6, 5, 6};
            Student student = new Student("Anna", "Zdravlkova", "4457", "0256475475", "anna@abv.bg", 4, marks);
            students.Add(student);
            marks = new List<byte>() { 6, 6, 6, 6 };
            student = new Student("Rosen", "Nilolaev", "5858", "024581234", "rosen@yahoo.com", 2, marks);
            students.Add(student);
            marks = new List<byte>() { 6, 6, 4, 6 };
            student = new Student("Angel", "Todorov", "6001", "0899735641", "angel.todorov@abv.bg", 2, marks);
            students.Add(student);
            marks = new List<byte>() { 6, 6, 4, 6 };
            student = new Student("Zdravka", "Dobreva", "4357", "0899345678", "zdravka.do@gmail.com", 3, marks);
            students.Add(student);
            marks = new List<byte>() { 6, 6, 6, 6 };
            student = new Student("Dimana", "Todorova", "5941", "0899778641", "Dimanka@abv.bg", 2, marks);
            students.Add(student);

            Console.WriteLine("Students:");
            PrintStudents(students);

            ////Select only the students that are from group number 2.
            ////• Use LINQ query. Order the students by FirstName.            

            var studentsGr2 = StudentServices.GetStudentsByGroup(students, 2);

            Console.WriteLine("9. Students in group number 2 (ordered by FirstName)(LINQ):");
            PrintStudents(studentsGr2);

            //10. Implement the previous using the same query expressed with extension methods.

             var studentsGr2Ext = StudentServices.GetStudentsByGroupExt(students, 2);

            Console.WriteLine("10. Students in group number 2 (ordered by FirstName) (extension methods):");
            PrintStudents(studentsGr2Ext);

            //11.Extract all students that have email in  abv.bg .
            //• Use  string  methods and LINQ.

            string domain = "abv.bg";           

            var studentsAbv = StudentServices.GetStudentsByEmailDomain(students, domain);

            Console.WriteLine("11. Students that have email in  abv.bg:");
            PrintStudents(studentsAbv);

            //12. Extract all students with phones in Sofia.
            //• Use LINQ.

            string phoneCode = "02";

            var studentsPhoneCode02 = StudentServices.GetStudentsByPhoneCode(students, phoneCode);

            Console.WriteLine("12. Students students with phones in Sofia.:");
            PrintStudents(studentsPhoneCode02);






        }

        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
