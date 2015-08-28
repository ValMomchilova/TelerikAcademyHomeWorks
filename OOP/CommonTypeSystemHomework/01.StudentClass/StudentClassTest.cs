using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//01. Define a class  Student , which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail,
//course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//• Override the standard methods, inherited by  System.Object :  Equals() ,  ToString() ,  GetHashCode()  and operators  ==  and  != .

//02. IClonable
//• Add implementations of the  ICloneable  interface.
//The  Clone()  method should deeply copy all object's fields into a new object of type  Student .

//3. IComparable
//• Implement the  IComparable<Student>  interface to compare students by names (as first criteria, in lexicographic order) 
//and by social security number (as second criteria, in increasing order).



namespace StudentClass
{
    class StudentClassTest
    {
        static void Main()
        {
            Student student1 = new Student("Petar", "Stefanov", "Petrov", "123467890",
                "Varna ul Dobrovnik 5", "0899745612", "p.petrov@abv.bg", 2, Specialty.EI, Faculty.Informatics, University.UEVarna);

            Student student2 = new Student("Ivan", "Ivanov", "Dimitrov", "789456109",
                "Varna bul Slivnica 187", "0899326594", "i.ivanov@abv.bg", 3, Specialty.KST, Faculty.KTA, University.TUVarna);

            Console.WriteLine("student1:");
            Console.WriteLine(student1);
            Console.WriteLine("HashCode: {0}", student1.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("student2:");
            Console.WriteLine(student2);
            Console.WriteLine("HashCode: {0}", student2.GetHashCode());
            Console.WriteLine();

            Student studentClone = student2.Clone() as Student;
            Console.WriteLine("studentClone:");
            Console.WriteLine(studentClone);
            Console.WriteLine("HashCode: {0}", studentClone.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("student1 Equals to student2? {0}", student1.Equals(student2));
            Console.WriteLine("student2 Equals to studentClone? {0}", student2.Equals(studentClone));

            Console.WriteLine("student1 == student2? {0}", student1 == student2);
            Console.WriteLine("student2 == studentClone? {0}", student2 == studentClone);

            Console.WriteLine("student1 != student2? {0}", student1 != student2);
            Console.WriteLine("student2 != studentClone? {0}", student2 != studentClone);
            Console.WriteLine();

            int comp = student1.CompareTo(student2);
            Console.WriteLine("student1 {0} student", GetSign(comp));

            comp = student2.CompareTo(studentClone);
            Console.WriteLine("student2 {0} studentClone", GetSign(comp));

        }

        public static string GetSign(int value)
        {
            string sign = "=";

            if (value < 0)
            {
                sign = "<";
            }
            else if (value > 0)
            {
                sign = ">";
            }

            return sign;
        }
    }
}
