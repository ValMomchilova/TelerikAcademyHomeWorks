using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2. Students and workers
//• Define abstract class  Human  with a first name and a last name.
//Define a new class  Student  which is derived from  Human  and has a new field –  grade . 
//Define class  Worker  derived from  Human  with a new property  WeekSalary  and  WorkHoursPerDay  and a method  MoneyPerHour()
//that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//• Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or  OrderBy()  extension method).
//• Initialize a list of 10 workers and sort them by money per hour in descending order.
//• Merge the lists and sort them by first name and last name.


namespace StudentsAndWorkers
{
    class StudentsAndWorkersTest
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            Student student = new Student("Nikola", "Ivanov", 1);
            students.Add(student);
            student = new Student("Zdravka", "Ivanova", 2);
            students.Add(student);
            student = new Student("Dimana", "Todorova", 1);
            students.Add(student);
            student = new Student("Stanimir", "Krasenov", 3);
            students.Add(student);
            student = new Student("Stojan", "Nikolov", 5);
            students.Add(student);
            student = new Student("Zornica", "Petrova", 1);
            students.Add(student);
            student = new Student("Aleksandar", "Gorspodinov", 2);
            students.Add(student);
            student = new Student("Nikolaj", "Ivanov", 3);
            students.Add(student);
            student = new Student("Kiril", "Kirilov", 2);
            students.Add(student);
            student = new Student("Nikola", "Petrov", 5);
            students.Add(student);

            //sort them by grade in ascending order (use LINQ or  OrderBy()  extension method).
            var studentsSortedByGrade = students.OrderBy(stud => stud.Grade);

            Console.WriteLine("Students sorted by grade:");

            foreach (var item in studentsSortedByGrade)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<Worker> workers = new List<Worker>();

            Worker worker = new Worker("Petar", "Ivanov", 600m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Petarana", "Nikolova", 300m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Stojan", "Angelov", 400m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Momchil", "Stojanov", 700m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Dona", "Stoeva", 200m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Todor", "Koev", 500m, 24, 2);
            workers.Add(worker);
            worker = new Worker("Kosta", "Ivanov", 700m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Dimitar", "Angelov", 400m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Angel", "Ivanov", 300m, 8, 5);
            workers.Add(worker);
            worker = new Worker("Petar", "Koev", 200.20m, 12, 2);
            workers.Add(worker);

            //sort them by money per hour in descending order.

            var workersSortedByMoneyPerHour = workers
                .Select(wr => new { Name = string.Format("{0} {1}", wr.FirstName, wr.LastName), MoneyPerHour = wr.GetMoneyPerHour() })
                .OrderByDescending(newwr => newwr.MoneyPerHour);

            Console.WriteLine("Workers sorted by money per hour");

            foreach (var item in workersSortedByMoneyPerHour)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Merge the lists and sort them by first name and last name.
            var humansList = students.Select(st => (Human)st)
                .Concat(workers.Select(wr => (Human)wr))
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName);

            Console.WriteLine("Humans sorted by first name and last name");

            foreach (var item in humansList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
