namespace StudentsExam
{
    using System;

    public class SimpleMathExam : Exam
    {
        public const int ProblemsCount = 2;
        public const int MinGrade = 2;
        public const int MaxGrade = 6;

        private int problemsSolved;    

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Problems solved can not be less than 0");
                }

                if (value > ProblemsCount)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Problems solved can not be greater that maximal problems count ({0})", ProblemsCount));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            int grade = 2;
            string comments = "Bad result: nothing done.";

            if (this.ProblemsSolved == 1)
            {
                grade = 4;
                comments = "Average result: half done.";
            }
            else if (this.ProblemsSolved == 2)
            {
                grade = 6;
                comments = "Excelent result: all done.";
            }

            return new ExamResult(grade, MinGrade, MaxGrade, comments);
        }
    }
}
