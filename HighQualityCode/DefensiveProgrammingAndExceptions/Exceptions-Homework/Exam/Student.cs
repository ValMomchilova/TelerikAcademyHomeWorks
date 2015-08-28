namespace StudentsExam
{
    using System;    
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("FirstName");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name can not be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("FirstName");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name can not be empty");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return new List<Exam>(this.exams);
            }

            set
            {
                if (value == null)
                {
                    this.exams = null;
                    return;
                }

                List<Exam> examsTmp = new List<Exam>();
                for (int i = 0; i < value.Count; i++)
                {
                    examsTmp.Add(value[i]);
                }

                this.exams = examsTmp;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                Console.WriteLine("The student has no exams!");
                return null;
            }

            if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!");
                return null;
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new Exception();
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
