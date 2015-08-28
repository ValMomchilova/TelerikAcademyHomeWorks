using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentsTest
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[] 
            {new Student("Alfa", "Betov", 24),
            new Student("Boris", "Aleksandrov", 28),
            new Student("Dimana", "Nikolova", 20),
            new Student("Nikola", "Dimov", 19),
             new Student("Dimo", "Dimov", 18)
            };

            Console.WriteLine("Students list:");
            Console.WriteLine(StudentsHelper.StudentsToStirng(students));
            Console.WriteLine();

            //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            Student[] studentsFirstIsBeforeLast = StudentsHelper.FindStudentsWhichFirstNameIsBeforeLast(students);
            Console.WriteLine("Students whose first name is before its last name alphabetically");
            Console.WriteLine(StudentsHelper.StudentsToStirng(studentsFirstIsBeforeLast));
            Console.WriteLine();

            //Write a LINQ query that finds the first name and last name of all students with age is between 18 and 24.
            Console.WriteLine("First name and last name of all students with age between 18 and 24");
            var studentsBetuween18and24Names = students.Where(student => student.Age >= 18 && student.Age <= 24)
                                                .Select(student => new { student.FirstName, student.LastName });

            foreach (var item in studentsBetuween18and24Names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Using the extension methods  OrderBy()  and  ThenBy()  
            //with lambda expressions sort the students by first name and last name in descending order.
            //Rewrite the same with LINQ.

            Console.WriteLine("students sorted by first name and last name in descending order(lambda expressions):");
            var orderedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var item in orderedStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("students sorted by first name and last name in descending order(LINQ):");
            var orderedStudentsLINQ = from student in students
                                      orderby student.FirstName descending, student.LastName descending
                                      select student;

            foreach (var item in orderedStudentsLINQ)
            {
                Console.WriteLine(item);
            }



        }
    }
}
