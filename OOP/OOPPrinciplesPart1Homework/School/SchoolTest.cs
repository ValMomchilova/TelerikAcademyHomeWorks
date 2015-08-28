using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. School classes
//• We are given a  school . 
//In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of disciplines. 
//Students have a name and unique class number. Classes have unique text identifier. 
//Teachers have a name. Disciplines have a name, number of lectures and number of exercises. 
//Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//• Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields,
// define the class hierarchy and create a class diagram with Visual Studio.


namespace School
{
    class SchoolTest
    {
        static void Main()
        {
            School scholl = new School("MG Petar Beron");
            
            SchoolClass schClass = new SchoolClass("4a");
            scholl.AddSchoolClass(schClass);

            Student student = new Student("Anna Dimova", 1);
            schClass.AddStudent(student);
            student = new Student("Biljana Asenova", 2);
            schClass.AddStudent(student);
            student = new Student("Georgi Ivanov", 3);
            schClass.AddStudent(student);
            student = new Student("Emil Stojanov", 4);
            schClass.AddStudent(student);

            Teacher teacherMath = new Teacher("Radka Petrova");
            Discipline discipline = new Discipline("Mathematics", 5, 2);
            teacherMath.AddDiscipline(discipline);
            discipline = new Discipline("Informatics", 3, 2);
            teacherMath.AddDiscipline(discipline);

            schClass.AddTeacher(teacherMath);

            Teacher teacherChem = new Teacher("Stojanka Stojanova");
            discipline = new Discipline("Chemistry", 5, 2);
            teacherChem.AddDiscipline(discipline);

            schClass.AddTeacher(teacherChem);

            Teacher teacherEng = new Teacher("Ivo Nikolov");
            discipline = new Discipline("Englich", 3, 1);
            teacherEng.AddDiscipline(discipline);

            schClass = new SchoolClass("4b");
            scholl.AddSchoolClass(schClass);

            student = new Student("Angel Dimov", 1);
            schClass.AddStudent(student);
            student = new Student("Bojan Ivanov", 2);
            schClass.AddStudent(student);
            student = new Student("Georgi Stojanov", 3);
            schClass.AddStudent(student);
            student = new Student("Emilija Dimova", 4);
            schClass.AddStudent(student);

            schClass.AddTeacher(teacherMath);
            schClass.AddTeacher(teacherChem);
            schClass.AddTeacher(teacherEng);

            Console.WriteLine(scholl);

        }
    }
}
